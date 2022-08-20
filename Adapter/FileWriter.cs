using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriter
    {
        public bool WriteToFile(string logInfo, string path)
        {
            Console.WriteLine($"write {logInfo} to {path}");
            return true;
        }
    }
}
