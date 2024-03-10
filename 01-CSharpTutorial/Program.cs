using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharpTutorial
{
    internal class Program
    {
        public int Id { get; set; }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Id = 0;
            string message = "¡Hello World!";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
    internal class Program2
    {
        public void metodo()
        {
            Program program = new Program();
            program.Id = 1;
        }
    }
}
