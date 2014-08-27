using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TaskManager
{
    /// <summary>
    /// This class contains all of the event handlers and business logic.
    /// See _TaskManagerForm.cs for the GUI layout code.
    /// </summary>
    partial class TaskManagerForm : Form
    {
        private Task parent;

        public TaskManagerForm() : this(null)
        {
        }

        public TaskManagerForm(Task node)
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.Visible = true;

            if (node == null)
                parent = new Task();

            else this.parent = node;

            PopulateTaskList();
        }

        public Task ParentNode
        {
            get { return parent; }
        }

        public void PopulateTaskList()
        {
            TaskTablePanel.Controls.Clear();

            foreach (Task t in parent.SubTasks)
                TaskTablePanel.Controls.Add(new TaskUserControl(t));
        }

        private void NewTaskButtonClicked(object sender, EventArgs args)
        {
            var newTask = new NewTaskWizardForm();
            newTask.ShowDialog();

            // check if adding new task was canceled
            if (newTask.TaskName == null && newTask.Description == null)
                return;

            parent.AddSubTask(new Task(newTask.TaskName, newTask.Description, newTask.DueDate));
            PopulateTaskList();

            //write to file
        }

        private void ClearDeleteTaskButtonClicked(object sender, EventArgs args)
        {
            // cannot use a foreach here as we will get a C# equivalent of Java's ConcurrentModificationException
            // remove all complete tasks
            for (int i = 0; i < parent.SubTasks.Count; i++)
                if (parent.SubTasks[i].IsComplete)
                    parent.RemoveSubTask(parent.SubTasks[i]);

            PopulateTaskList();
        }
    }
}