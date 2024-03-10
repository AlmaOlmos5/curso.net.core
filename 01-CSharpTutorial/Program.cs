using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharpTutorial
{
    internal class Program
    {
        public int Id { get; set; }

        public class @ejemplo
        {
            public String Saludo { get; set; }
        }
        static void Main(string[] args)
        {
            bool MayorEdad = true;
            string message = "¡Hello World!";
            ejemplo ej = new ejemplo();
            ej.Saludo = "Saludo desde un objeto en otra clase";
            Console.WriteLine(message);
            Console.WriteLine(ej.Saludo);

            Console.ReadLine();

        }
        void metodo()
        {
            this.Id=0;
        }
        
        
    }
   
}
