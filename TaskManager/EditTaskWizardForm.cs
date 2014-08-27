using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class EditTaskWizardForm : NewTaskWizardForm
    {
        private Task original;

        public EditTaskWizardForm(ref Task task) : base()
        {
            this.Text = TaskManagerUtil.TASK_WIZARD_EDIT_TITLE;

            this.TaskName = task.Name;
            this.NameText.Text = task.Name;

            this.Description = task.Description;
            this.DescriptionText.Lines = task.Description;

            if (task.DueDate == default(DateTime))
            {
                this.DueDate = default(DateTime);
                DueDatePicker.Enabled = false;
                NoDueDateCheckBox.Checked = true;
            }

            original = task;
        }
    }
}
