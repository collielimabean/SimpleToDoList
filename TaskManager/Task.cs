using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    [Serializable()]
    public class Task : IComparable<Task>
    {
        public Task () : this (null, null, default(DateTime))
        {
        }

        public Task(string Name) : this(Name, null, default(DateTime))
        {
        }

        public Task(string Name, string[] Description) : this(Name, Description, default(DateTime))
        {
        }

        public Task(string Name, string[] Description, DateTime DueDate)
        {
            this.Name = Name;
            this.Description = Description;
            this.DueDate = DueDate;
            this.IsComplete = false;
            SubTasks = new List<Task>();
        }

        public string Name
        {
            get;
            set;
        }

        public DateTime DueDate
        {
            get;
            set;
        }

        public string[] Description
        {
            get;
            set;
        }

        public List<Task> SubTasks
        {
            get;
            private set;
        }

        public bool IsComplete
        {
            get;
            set;
        }

        public void AddSubTask(Task task)
        {
            if (task == null)
                return;

            SubTasks.Add(task);
            SubTasks.Sort();
        }

        public bool RemoveSubTask(Task task)
        {
            return SubTasks.Remove(task);
        }

        public int CompareTo(Task task)
        {
            if (this.DueDate == default(DateTime) && task.DueDate == default(DateTime))
                return this.Name.CompareTo(task.Name);

            else if (this.DueDate == default(DateTime) && task.DueDate != default(DateTime))
                return 1;

            else if (this.DueDate != default(DateTime) && task.DueDate == default(DateTime))
                return -1;

            else return this.DueDate.CompareTo(task.DueDate);
        }
        
        public override bool Equals(Object obj)
        {
            Task task = obj as Task;

            if (task == null)
                return false;
            
#warning Tasks will be considered same even if their subtasks differ!
 
            else return (Name.Equals(task.Name))
                && (DueDate.Equals(task.DueDate)) 
                && (Description.Equals(task.Description));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
