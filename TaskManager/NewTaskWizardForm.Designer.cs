namespace TaskManager
{
    partial class NewTaskWizardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.DueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NoDueDateCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = TaskManagerUtil.TASK_WIZARD_NAME;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(55, 13);
            this.NameText.MaxLength = 100;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(278, 20);
            this.NameText.TabIndex = 1;
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(12, 59);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.DueDateLabel.TabIndex = 2;
            this.DueDateLabel.Text = TaskManagerUtil.TASK_WIZARD_DATE;
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.Checked = false;
            this.DueDatePicker.Location = new System.Drawing.Point(133, 56);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.DueDatePicker.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 91);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = TaskManagerUtil.TASK_WIZARD_DESCRIPTION;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(16, 107);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionText.Size = new System.Drawing.Size(317, 105);
            this.DescriptionText.TabIndex = 5;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(258, 231);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 6;
            this.OK_Button.Text = TaskManagerUtil.TASK_WIZARD_OK;
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(177, 231);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = TaskManagerUtil.TASK_WIZARD_CANCEL;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoDueDateCheckBox
            // 
            this.NoDueDateCheckBox.AutoSize = true;
            this.NoDueDateCheckBox.Location = new System.Drawing.Point(75, 59);
            this.NoDueDateCheckBox.Name = "NoDueDateCheckBox";
            this.NoDueDateCheckBox.Size = new System.Drawing.Size(52, 17);
            this.NoDueDateCheckBox.TabIndex = 9;
            this.NoDueDateCheckBox.Text = TaskManagerUtil.TASK_WIZARD_NONE;
            this.NoDueDateCheckBox.UseVisualStyleBackColor = true;
            this.NoDueDateCheckBox.CheckedChanged += new System.EventHandler(this.NoDueDateCheckBox_CheckedChanged);
            // 
            // NewTaskWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 266);
            this.Controls.Add(this.NoDueDateCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DueDatePicker);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTaskWizardForm";
            this.ShowInTaskbar = false;
            this.Text = TaskManagerUtil.TASK_WIZARD_ADD_TITLE;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button CancelButton;
        protected System.Windows.Forms.TextBox NameText;
        protected System.Windows.Forms.DateTimePicker DueDatePicker;
        protected System.Windows.Forms.CheckBox NoDueDateCheckBox;
        protected System.Windows.Forms.TextBox DescriptionText;
    }
}