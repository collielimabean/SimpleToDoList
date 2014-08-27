using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    partial class TaskUserControl : UserControl
    {
        private Task task;

        public TaskUserControl(Task task)
        {
            this.task = task;
            InitializeComponent();

            TaskName.Text = task.Name;

            if (task.DueDate != default(DateTime))
                TaskDate.Text = task.DueDate.ToShortDateString();

            // if the main form is disposed, this will retain completion status
            if (task.IsComplete)
                SelectCheckBox.Checked = true;

            else SelectCheckBox.Checked = false;

            // force trigger the event for the text
            SelectCheckBox_CheckedChanged(this, null);
        }

        private void SelectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectCheckBox.Checked) 
            {
                TaskName.Font = new Font(TaskName.Font, FontStyle.Strikeout);
                TaskDate.Font = new Font(TaskDate.Font, FontStyle.Strikeout);
                task.IsComplete = true;
            }

            else
            {
                TaskName.Font = new Font(TaskName.Font, FontStyle.Regular);
                TaskDate.Font = new Font(TaskDate.Font, FontStyle.Regular);
                task.IsComplete = false;
            }
        }

        private void TaskClick(object sender, EventArgs e)
        {
            // ignore request for edit if complete
            if (SelectCheckBox.Checked)
                return;

            EditTaskWizardForm editor = new EditTaskWizardForm(ref task);
            editor.ShowDialog();

            task.Name = editor.TaskName;
            task.DueDate = editor.DueDate;
            task.Description = editor.Description;
        }
    }
}
