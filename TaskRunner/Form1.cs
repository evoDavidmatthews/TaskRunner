using Infrastructure.Models;
using Infrastructure.Repositories.Functions;
using System.Collections.Generic;

namespace TaskRunner
{
    public partial class Form1 : Form
    {
        private FunctionsRepository functionsRepository;
        static Function selectedFunction = new();
        public List<Control> controls = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            this.functionsRepository = new FunctionsRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Function[] functions = this.functionsRepository.GetAll().ToArray();
            this.AvailableFunctionsList.Items.AddRange(functions.ToArray());

            IleftGinger person = new Person();
            
            Bouncer bouncer = new();

            bool boo = bouncer.AllowEntrance(person);



        }

        private void AvailableFunctionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableFunctionsList.SelectedIndex == -1) return;
            int i = AvailableFunctionsList.SelectedIndex;
            Function function = (Function)AvailableFunctionsList.Items[i];
            DescriptionBox.Text = function.Description;
            selectedFunction = function;

            foreach (Control control in controls)
            {
                Controls.Remove(control);
            }


            for (int y = 0; y < function.Arguments.Length; y++)
            {
                object? item = function.Arguments[y];
                Type t = item.GetType();
                TextBox textbox = new TextBox();
                textbox.Text = item.ToString();
                textbox.Size = new Size(127, 29);
                textbox.Location = new Point(127 * y, 0);
                textbox.Tag = "temp:" + y;
                textbox.KeyUp += TempBox_KeyUp;
                this.Controls.Add(textbox);
                textbox.BringToFront();
                controls.Add(textbox);
            }
        }

        private void TempBox_KeyUp(object sender, EventArgs e)
        {

            TextBox activeTextBox = this.ActiveControl as TextBox;
            int argSelector = int.Parse(activeTextBox.Tag.ToString().Split(":")[1]);
            Type t = selectedFunction.Arguments[argSelector].GetType();
            try
            {
                object o = Convert.ChangeType(activeTextBox.Text, t);
                selectedFunction.Arguments[argSelector] = o;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"updated value to {selectedFunction.Arguments[argSelector]}");
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"invoking {selectedFunction.Name} in seperate thread");
            Task t = Task.Run(() =>
            {
                selectedFunction.Func.Invoke(selectedFunction.Arguments);
            });
            Console.WriteLine($"succesfully invoked on task id {t.Id}");
        }
    }
}
