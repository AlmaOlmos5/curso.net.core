using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_InicializacionObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std0 = new Student()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };
            var std1 = new Student();
            std1.StudentID = 2;
            std1.StudentName = "Alma";
            std1.Age = 29;
            std1.Address = "Oaxaca";

            var std2 = new Student() { StudentID = 1, StudentName = "María" };
            var std3 = new Student() { StudentID = 2, StudentName = "Juan" };
            var std4 = new Student() { StudentID = 3, StudentName = "Pedro" };
            var std5 = new Student() { StudentID = 4, StudentName = "Alberto" };
            var std6 = new Student() { StudentID = 5, StudentName = "Fernando" };
            IList<Student> ListaEstudiantes = new List<Student>()
            {
                std2, std3, std4, std5, std6
            };

            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John"} ,
                    new Student() { StudentID = 2, StudentName = "Steve"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 4, StudentName = "Ram" } ,
                    new Student() { StudentID = 5, StudentName = "Ron" }
                };

        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
