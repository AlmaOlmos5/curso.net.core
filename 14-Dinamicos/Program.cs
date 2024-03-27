using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Dinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int miEntero = 0;
            dynamic MyDynamicVar = 1;
            Console.WriteLine(miEntero.GetType());
            Console.WriteLine(MyDynamicVar.GetType());

            //Cambiando de valor a la Variable dinámica
            dynamic MyDynamicVar1 = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar1, MyDynamicVar1.GetType());

            MyDynamicVar1 = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar1, MyDynamicVar1.GetType());

            MyDynamicVar1 = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar1, MyDynamicVar1.GetType());

            MyDynamicVar1 = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar1, MyDynamicVar1.GetType());

            //Conversión dinámica de datos

            dynamic d1 = 100;
            int i = d1;

            d1 = "Hello";
            string greet = d1;

            d1 = DateTime.Now;
            DateTime dt = d1;

            //Métodos y parámetros
            dynamic estudiante1=new Estudiante();
            /*
            estudiante1.DisplayStudentInfo(1, "Bill");//Dará error en tiempo de ejecución pouqe ningún constructor tiene dos atributos
            estudiante1.DisplayStudentInfo("1");// Error en tiempo de compilación y también de ejecución.
            estudiante1.FakeMethod();//Error en ejecución porque no existe el método
            */
            estudiante1.DisplayStudentInfo(10);
        }
    }
}
