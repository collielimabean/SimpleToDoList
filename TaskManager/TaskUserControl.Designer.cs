namespace TaskManager
{
    partial class TaskUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskUserControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectCheckBox = new System.Windows.Forms.CheckBox();
            this.TaskName = new System.Windows.Forms.Label();
            this.TaskDate = new System.Windows.Forms.Label();
            this.TaskUserControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskUserControlPanel
            // 
            this.TaskUserControlPanel.ColumnCount = 3;
            this.TaskUserControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TaskUserControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TaskUserControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TaskUserControlPanel.Controls.Add(this.SelectCheckBox, 0, 0);
            this.TaskUserControlPanel.Controls.Add(this.TaskName, 1, 0);
            this.TaskUserControlPanel.Controls.Add(this.TaskDate, 2, 0);
            this.TaskUserControlPanel.Location = new System.Drawing.Point(3, 3);
            this.TaskUserControlPanel.Name = "TaskUserControlPanel";
            this.TaskUserControlPanel.RowCount = 1;
            this.TaskUserControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TaskUserControlPanel.Size = new System.Drawing.Size(395, 33);
            this.TaskUserControlPanel.TabIndex = 0;
            // 
            // SelectCheckBox
            // 
            this.SelectCheckBox.AutoSize = true;
            this.SelectCheckBox.Location = new System.Drawing.Point(3, 3);
            this.SelectCheckBox.Name = "SelectCheckBox";
            this.SelectCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SelectCheckBox.TabIndex = 0;
            this.SelectCheckBox.UseVisualStyleBackColor = true;
            this.SelectCheckBox.CheckedChanged += new System.EventHandler(this.SelectCheckBox_CheckedChanged);
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Location = new System.Drawing.Point(24, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(0, 13);
            this.TaskName.TabIndex = 1;
            this.TaskName.Click += new System.EventHandler(this.TaskClick);
            // 
            // TaskDate
            // 
            this.TaskDate.AutoSize = true;
            this.TaskDate.Location = new System.Drawing.Point(211, 0);
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.Size = new System.Drawing.Size(0, 13);
            this.TaskDate.TabIndex = 2;
            this.TaskDate.Click += new System.EventHandler(this.TaskClick);
            // 
            // TaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskUserControlPanel);
            this.Name = "TaskUserControl";
            this.Size = new System.Drawing.Size(395, 36);
            this.TaskUserControlPanel.ResumeLayout(false);
            this.TaskUserControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TaskUserControlPanel;
        private System.Windows.Forms.CheckBox SelectCheckBox;
        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.Label TaskDate;
    }
}
