using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    static class TaskManagerMain
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ensure that the directory exists so that we can store data
            if (!Directory.Exists(TaskManagerUtil.TASK_MANAGER_DATA_FOLDER))
                Directory.CreateDirectory(TaskManagerUtil.TASK_MANAGER_DATA_FOLDER);

            TaskManagerTray tray = new TaskManagerTray();
            Application.Run();

        }
    }
}
