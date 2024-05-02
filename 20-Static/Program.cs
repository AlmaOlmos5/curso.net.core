using System;

namespace _20_Static
{
    internal class Program : ProgramBase
    {
        static int counter = 0;
        string name = "Demo Program";

        static void Main(string[] args)
        {

            //Prueba de constructores estáticos
            StopWatch sw0=new StopWatch();
            StopWatch.DisplayInfo();

            //Uso de la claseestática
            /*var result = Calculator.Sum(10, 25);
            Calculator.Store(result);
            var CalcType = Calculator.Type;
            Calculator.Type = "Scientific";
            */

            //Uso de campos estáticos dentro de una clase no estática
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4
           

            //Cada objeto imprime el número de instancia
            sw1.PrintNoInstancias();
            sw2.PrintNoInstancias();
            sw3.PrintNoInstancias();

            counter++; // can access static fields
            Display("Hello World!"); // can call static methods

            Program program=new Program();
            program.name = "New Demo Program"; //name = "New Demo Program" nos dio Error: no se puede acceder a un elemento no estático
            program.SetRootFolder("C:/MyProgram"); //Se debe crear un objeto de la clase para poder acceder a sus métodos.

            Console.WriteLine(Program.GetSaludo());
        }
        static void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void SetRootFolder(string path) { }

        public static string GetSaludo()
        {
            // static string saludo = "Hola Mundo"; //No se puede acceder a variables estáticas
            // return "Hola Mundo" + name; No se puede llamar una variable no estática.

            return "Hola Mundo";
        }
        public static string GetSaludo(string nombre)
        {
            return "Hola " + nombre;
        }
        public static string GetSaludo(string nombre, string apellido)
        {
            return "Hola " + nombre + " " + apellido;
        }
    }
    public class ProgramBase
    {
        public static string GetSaludo()
        {
            return "Hola Mundo";
        }
    }
}
