using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    public class FileInfo3 : IFile, IBinaryFile
    {
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        void IFile.ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writing Text File");
        }
        public void Search(string text)
        {
            Console.WriteLine("Searching in File");
        }
    }
}
