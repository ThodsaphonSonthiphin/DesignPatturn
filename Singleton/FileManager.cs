using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class FileManager
    {
        public string Id { get; } = Guid.NewGuid().ToString();
       private  FileManager()
        {
            
        }

       private static FileManager _fileManager;

       public static FileManager GetInstance()
       {
           if (_fileManager == null)
           {
               _fileManager = new FileManager();
           }

           return _fileManager;
       }

       public string ReadFile()
       {
           return $"{this.Id} read file";
       }

    }
}
