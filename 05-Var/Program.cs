using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine("El tipo de dato de i es {0}", i.GetType());

            var str = "Hello World!!";
            Console.WriteLine("El tipo de dato de str es {0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("El tipo de dato de  dbl es {0}", dbl.GetType());

            var isValid = true;
            Console.WriteLine("El tipo de dato de isValid es {0}", isValid.GetType());

            var anon = new { name = "Steve" };
            Console.WriteLine("El tipo de dato de anon es {0}", anon.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("El tipo de dato de arr es {0}", arr.GetType());
            
            var file = new FileInfo("MyFile");
            Console.WriteLine("El tipo de dato de file es {0}", file.GetType());


            //Utilizando var en un ciclo for
            for(var j=0;j<10; j++)
            {
                Console.WriteLine(j);
            }

            // string collection
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };
            var result = from elemento in stringList 
                         where elemento.Contains("Tutorials") 
                         select elemento;
            foreach (var elemento in result)
            {
                Console.WriteLine(result.ToArray());

            }
            Console.ReadLine();
        }
    }
}
