using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creación de objetos utilizando el espacio de nombre.
            School.Student student =new School.Student(); 
            School.Course course = new School.Course();
            Creación de objetos importando el namespace.
            Student student2 = new Student();
            Course course2 = new Course();
            */

            School.Student student = new School.Student();
            School.Course course = new School.Course();

            School.Education.Student student1 = new School.Education.Student(); 
            School.Education.Course course1 = new School.Education.Course();

        }
    }
}
