using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enumeracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiasSemana dia1 = DiasSemana.Lunes;
            Console.WriteLine((int)dia1);
            DiasSemana dia2 = DiasSemana.Viernes;
            Console.WriteLine((int)dia2);
            Console.WriteLine(dia1);
            Console.WriteLine(dia2);

            //Categorías
            Categories cat1 = Categories.Automotive;
            Console.WriteLine((int)cat1);
            Categories cat2 = Categories.Food;
            Console.WriteLine((int)cat2);

            Categories2 cat3 = Categories2.Electronics;
            Console.WriteLine((int)cat3);
            Categories2 cat4= Categories2.Fashion;
            Console.WriteLine((int)cat4);


            Console.WriteLine(DiasSemana.Martes);
            Console.WriteLine(DiasSemana.Sabado);
            Console.WriteLine(DiasSemana.Domingo);

            int dia = (int)DiasSemana.Viernes;
            Console.WriteLine(dia);

            DiasSemana _diaSem = (DiasSemana)5;
            Console.WriteLine(_diaSem);
        }
    }

}
