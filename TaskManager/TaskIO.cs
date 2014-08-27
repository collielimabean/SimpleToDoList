using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace TaskManager
{
    static class TaskIO
    {
        private static XmlSerializer writer = new XmlSerializer(typeof(Task));
 
        public static bool WriteToFile(string filePath, Task tasks)
        {
            if (tasks == null)
                return false;

            using (var stream = File.OpenWrite(filePath))
            {
                writer.Serialize(stream, tasks);
            }

            return true;
        }

        public static Task ReadFromFile(string filePath)
        {
#warning You are playing with dangerous fires by using null as a failure value, my friend

            if (!File.Exists(filePath))
                return null;

            using (var stream = File.OpenRead(filePath))
            {
                // failing to deserialize!
                return writer.Deserialize(stream) as Task;
            }
        }
    }
}
