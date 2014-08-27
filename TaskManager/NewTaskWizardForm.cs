using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class NewTaskWizardForm : Form
    {
        public NewTaskWizardForm()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get;
            protected set;
        }

        public DateTime DueDate
        {
            get;
            protected set;
        }

        public string[] Description
        {
            get;
            protected set;
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void OK_Button_Click(object sender, EventArgs e)
        {
            TaskName = NameText.Text;
            Description = DescriptionText.Lines;

            if (NoDueDateCheckBox.Checked)
                DueDate = default(DateTime);

            else DueDate = DueDatePicker.Value.Date;

            this.Close();
        }

        protected void NoDueDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoDueDateCheckBox.Checked)
                DueDatePicker.Enabled = false;
        }

    }
}
