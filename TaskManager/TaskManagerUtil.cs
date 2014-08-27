using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public static class TaskManagerUtil
    {
        public static readonly string TASK_MANAGER_DATA_FOLDER = Application.UserAppDataPath;
        public static readonly string TASK_MANAGER_DATA_FILE = TASK_MANAGER_DATA_FOLDER + "\\tasks.xml";

        public static readonly string TRAY_ICON_TITLE = "To-do List Manager";
        public static readonly string TRAY_ICON_ABOUT = "About";
        public static readonly string TRAY_ICON_EXIT = "Exit";

        public static readonly string TASK_FORM_TITLE = TRAY_ICON_TITLE;
        public static readonly string TASK_FORM_NEW = "New";
        public static readonly string TASK_FORM_CLEAR_DELETE = "Clear/Delete";

        public static readonly string TASK_WIZARD_ADD_TITLE = "Add New Task";
        public static readonly string TASK_WIZARD_EDIT_TITLE = "Edit Task";
        public static readonly string TASK_WIZARD_NAME = "Name:";
        public static readonly string TASK_WIZARD_DATE = "Date: ";
        public static readonly string TASK_WIZARD_DESCRIPTION = "Description:";
        public static readonly string TASK_WIZARD_NONE = "None";
        public static readonly string TASK_WIZARD_OK = "OK";
        public static readonly string TASK_WIZARD_CANCEL = "Cancel";
    }
}
