using TaskManager;
using TaskManager.Models;

namespace TaskRunner
{
    public partial class Form1 : Form
    {
        private TaskDto selectedTask = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TaskDto> tasks = [.. TaskManagement.GetTasks()];
            this.AvailableTasksList.Items.AddRange(tasks.ToArray());
        }

        private void AvailableTasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableTasksList.SelectedIndex == -1) return;
            int i = AvailableTasksList.SelectedIndex;
            TaskDto task = (TaskDto)AvailableTasksList.Items[i];
            DescriptionBox.Text = task.Description;
            selectedTask = task;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            TaskManagement.RunTask(selectedTask);
        }


    }
}
