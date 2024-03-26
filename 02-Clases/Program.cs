using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            estudiante1.EstudianteId = 10;
            estudiante1.Nombre = "María Fernanda";
            estudiante1.ApellidoPaterno = "Campos";
            estudiante1.ApellidoMaterno = "Olmos";
            String ResultadoNombreCompleto1 = estudiante1.NombreCompleto();

            Estudiante estudiante2 = new Estudiante();
            estudiante2.EstudianteId = 11;
            estudiante2.Nombre = "Alma";
            estudiante2.ApellidoPaterno = "Olmos";
            estudiante2.ApellidoMaterno = "Pantoja";
            String ResultadoNombreCompleto2 = estudiante2.NombreCompleto();

            Estudiante estudiante3 = new Estudiante(12, "Juan", "González", "Pépez");
            String ResultadoNombreCompleto3 = estudiante3.NombreCompleto();

            Aritmetica aritmetica1 = new Aritmetica();
            int resultadoSuma = aritmetica1.Suma(5, 6);
            aritmetica1.Saludo();

        }
    }
}
