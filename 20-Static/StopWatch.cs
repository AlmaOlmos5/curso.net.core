using System;

namespace _20_Static
{
    public class StopWatch
    {
        public static int NoOfInstances = 0;
        //Constructor estático
        static StopWatch()
        {
            NoOfInstances = 10;
            Console.WriteLine("Llamando al constructor estático");
        }
        /*public StopWatch()
        {
            Console.WriteLine("Llamando al constructor de instancia");
        }*/
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
            Console.WriteLine("Llamando al Constructor de instancia");
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("Llamando a DisplayInfo");
        }
        public void Start()
        {

        }
        public void Stop()
        {

        }
        public void PrintNoInstancias()
        {
            Console.WriteLine(StopWatch.NoOfInstances);
        }
        public static void Metodo1()
        {

        }

    }
}
