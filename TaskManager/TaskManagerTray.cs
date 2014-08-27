using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace TaskManager
{
    class TaskManagerTray : IDisposable
    {
        private TaskManagerForm mainForm;
        private NotifyIcon tray;
        private ContextMenu menu;
        private Task loaded;
        bool disposed;

        public TaskManagerTray()
        {
            InitializeComponents();

            loaded = TaskIO.ReadFromFile(TaskManagerUtil.TASK_MANAGER_DATA_FILE);
            disposed = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {

            }

            disposed = true;
        }

        private void InitializeComponents()
        {
            tray = new NotifyIcon(new Container());
            menu = new ContextMenu();

            MenuItem exit = new MenuItem(TaskManagerUtil.TRAY_ICON_EXIT);
            exit.Click += Exit_Click;

            menu.MenuItems.AddRange(new MenuItem[] 
            {
                exit
            });

            tray.Text = TaskManagerUtil.TRAY_ICON_TITLE;
            tray.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            tray.ContextMenu = menu;
            tray.MouseDoubleClick += Tray_DoubleClicked;
            tray.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
                TaskIO.WriteToFile(TaskManagerUtil.TASK_MANAGER_DATA_FILE, mainForm.ParentNode);

            Application.Exit();
        }

        private void Tray_DoubleClicked(object sender, EventArgs args)
        {
            if (mainForm == null)
            {
                if (loaded == null)
                    mainForm = new TaskManagerForm();

                else mainForm = new TaskManagerForm(loaded);
            }

            else if (mainForm.IsDisposed)
            {
                mainForm = new TaskManagerForm(mainForm.ParentNode);
            }

            else
            { 
                mainForm.WindowState = FormWindowState.Normal; 
            }
        }
    }
}
