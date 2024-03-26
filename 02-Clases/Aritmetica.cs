using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    internal class Aritmetica
    {
        public int Suma (int num1, int num2)
        {
            int total= num1 + num2;
            return total;
        }

        public void Saludo()
        {
            Console.WriteLine("Hola desde el objeto Aritmética");
        }
    }
}
