using System;

namespace _20_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de la claseestática
            var result = Calculator.Sum(10, 25);
            Calculator.Store(result);
            var CalcType = Calculator.Type;
            Calculator.Type = "Scientific";
            Console.ReadLine();

            //Uso de campos estáticos dentro de una clase no estática
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4
        }
    }
}
