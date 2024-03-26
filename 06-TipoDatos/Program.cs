using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TipoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 100;
            Console.WriteLine("El valor de la variable num1 es: {0}",num1);

            sbyte num2 = 127;
            Console.WriteLine("El valor de la variable num2 es: {0}", num2);

            uint num3 = 1000u;
            Console.WriteLine("El valor de la variable num3 es: {0}", num3);

            long num4 = 150l;
            Console.WriteLine("El valor de la variable num4 es: {0}", num4);

            DateTime fecha = new DateTime(2024, 03, 20, 9, 10, 19);
            Console.WriteLine("El valor de la variable fecha es: {0}", fecha);

            //inicialización de variables por default
            int i = default;
            Console.WriteLine("El valor de la variable i es {0}",i);

            //Conversión implícita
            int j = 345;
            float f = j;
            Console.WriteLine("El valor de la variable f es {0}", f);

            //Conversión explícita
            int h = 100;
            uint u = (uint)h;
            Console.WriteLine("El  valor de la variable u es {0}",u);

            Console.WriteLine();



        }
    }
}
