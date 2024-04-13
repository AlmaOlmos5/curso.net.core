using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    public class FileInfo2 : IFile
    {
        public string fileName = "MiArchivo.txt";
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
        public void Search(string text)
        {
            Console.WriteLine("Searching in file");
        }

    }
}
