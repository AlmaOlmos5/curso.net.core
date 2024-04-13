using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ValueTypesAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo Valor
            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);

            //Tipo por referencia
            Estudiante estudiante = new Estudiante();
            estudiante.Id = 1;
            estudiante.Nombre = "Juan";
            Console.WriteLine($"Id: {estudiante.Id}, Nombre: {estudiante.Nombre}");
            ChangeValue2(estudiante);
            Console.WriteLine($"Id: {estudiante.Id}, Nombre: {estudiante.Nombre}");
        }
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
        static void ChangeValue2(Estudiante estudiante)
        {
            estudiante.Id = 2;
            estudiante.Nombre = "Andrea";
            Console.WriteLine($"Id: {estudiante.Id}, Nombre: {estudiante.Nombre}");
        }
    }
    class Estudiante
    {
        public int Id { get; set; }
        public String Nombre { get; set;}
    }
}
