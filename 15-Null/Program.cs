using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIÓN Y USO DEL NULLEABLE
            Nullable<int> i = null;
            if(i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }
            Console.WriteLine(i.GetValueOrDefault());

            //SINTAXIS ABREVIADA DEL NULLEABLE
            int? j = null;
            double? d = null;
            Estudiante estudiante = null;

            int? k = null;
            int h = k ?? 0;

            //EJEMPLO DE UN CAMPO NULLEABLE EN CLASE (variable global)
            Estudiante estudiante2=new Estudiante();
            Console.WriteLine(estudiante2.GetIdEstudiante());

            //COMPARACIÓN CON NULLEABLE  
            int? a = null;
            int b = 10;

            //a y b no se pueden comparar
            if (a < b)
                Console.WriteLine("a < b");
            else if (a > b)
                Console.WriteLine("a > b");
            else if (a == b)
                Console.WriteLine("a == b");
            else
                Console.WriteLine("No se puede comparar");

            //Clase auxiliar
            //Aquí si se puede comparar porque lo pasa a entero
            if (Nullable.Compare<int>(a, b) < 0)
                Console.WriteLine("a < b");
            else if (Nullable.Compare<int>(a, b) > 0)
                Console.WriteLine("a > b");
            else
                Console.WriteLine("a = b");
        }
    }
}
