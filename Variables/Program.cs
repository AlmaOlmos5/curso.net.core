using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = false;
            string nombre = "Alma";
            //Para evitar los warnings debemos utilizar las variables declaradas.
            Console.WriteLine(num);
            Console.WriteLine(rate);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(nombre);

            //Errores cometidos:
            //Asignar un valor de diferente tipo al declarado: int num1="Alma";

            //

        }
    }
}
