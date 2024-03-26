using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            float raid = 10.2f;
            decimal amount = 100.5m;
            char code = 'c';
            bool isValid = true;
            string name = "Alma";

            Console.WriteLine(num);
            Console.WriteLine(raid);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(name);

            //Error! Declarar y asignar después
            int num2;
            num2 = 100;
            Console.WriteLine(num2);

            //Asignación NO VÁLIDA
            //int i; 
            //int j=i;

            int num3 = 100;
            num3 = 200;
            Console.WriteLine(num3);

            //Declarar e iniicalizar núltiples variables
            int i, j = 10, k = 100;
            i = 5;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //Declarar e inicializar múltiples variables en diferentes líneas
            int i1=1,
                j1=10,
                k1 = 100;
            Console.WriteLine(i1);
            Console.WriteLine(j1);
            Console.WriteLine(k1);

            //Asignación de variables
            int i2 = 10;
            int j2 = i2;

            //Variables y expresiones
            int i3 = 100;
            int j3 = i3 + 20;
            Console.WriteLine("j3 = {0}, i3 = {1}",j3,i3);

            //Variables con var
            var i5 = 5;
            Console.WriteLine(i5);
        }
    }
}
