using TaskManager;
using Task = TaskRunner.Models.Task;

namespace TaskRunner
{
    public partial class Form1 : Form
    {
        private Task selectedFunction = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Task> tasks = [.. TaskManagement.GetTasks()];
            this.AvailableFunctionsList.Items.AddRange(tasks.ToArray());
        }

        private void AvailableFunctionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableFunctionsList.SelectedIndex == -1) return;
            int i = AvailableFunctionsList.SelectedIndex;
            Task function = (Task)AvailableFunctionsList.Items[i];
            DescriptionBox.Text = function.Description;
            selectedFunction = function;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            TaskManagement.RunTask(selectedFunction.Id);
        }
    }
}
