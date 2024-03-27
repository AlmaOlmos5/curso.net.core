using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Anonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student1.Id); //output: 1
            Console.WriteLine(student1.FirstName); //output: James
            Console.WriteLine(student1.LastName); //output: Bond
            
            //Anonimos anidados
            var student2 = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            Console.WriteLine(student2);

            //Matriz de tipos anónimos
            var students1 = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };

            //
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
            };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName };

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "-" + stud.Name);


            //Nombre interno de un anónimo
            var student5 = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student5.GetType().ToString());
        }
    }
}
