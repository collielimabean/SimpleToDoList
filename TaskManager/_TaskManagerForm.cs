using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    /// <summary>
    /// This class contains all layout and component initializations for the main Task Manager windows.
    /// See TaskManagerForm.cs if you want to see event handling.
    /// </summary>
    partial class TaskManagerForm : Form
    {
        private ToolStrip MenuStrip;
        private ToolStripButton ClearDeleteTaskButton;
        private TableLayoutPanel TaskTablePanel;
        private ToolStripButton NewTaskButton;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerForm));
            this.MenuStrip = new System.Windows.Forms.ToolStrip();
            this.NewTaskButton = new System.Windows.Forms.ToolStripButton();
            this.ClearDeleteTaskButton = new System.Windows.Forms.ToolStripButton();
            this.TaskTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTaskButton,
            this.ClearDeleteTaskButton});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(334, 25);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("NewTaskButton.Image")));
            this.NewTaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(51, 22);
            this.NewTaskButton.Text = TaskManagerUtil.TASK_FORM_NEW;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButtonClicked);
            // 
            // ClearDeleteTaskButton
            // 
            this.ClearDeleteTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearDeleteTaskButton.Image")));
            this.ClearDeleteTaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearDeleteTaskButton.Name = "ClearDeleteTaskButton";
            this.ClearDeleteTaskButton.Size = new System.Drawing.Size(92, 22);
            this.ClearDeleteTaskButton.Text = TaskManagerUtil.TASK_FORM_CLEAR_DELETE;
            this.ClearDeleteTaskButton.Click += new System.EventHandler(this.ClearDeleteTaskButtonClicked);
            // 
            // TaskTablePanel
            // 
            this.TaskTablePanel.ColumnCount = 1;
            this.TaskTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TaskTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TaskTablePanel.Location = new System.Drawing.Point(0, 29);
            this.TaskTablePanel.Name = "TaskTablePanel";
            this.TaskTablePanel.RowCount = 2;
            this.TaskTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TaskTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TaskTablePanel.Size = new System.Drawing.Size(322, 395);
            this.TaskTablePanel.TabIndex = 1;
            // 
            // TaskManagerForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 436);
            this.Controls.Add(this.TaskTablePanel);
            this.Controls.Add(this.MenuStrip);
            this.MaximizeBox = false;
            this.Name = "TaskManagerForm";
            this.Text = TaskManagerUtil.TASK_FORM_TITLE;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
