using System.Runtime.InteropServices;

namespace _25_OperadorTernario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            //SENTENCIA 1
            bool condicion=true;
            if(condicion)
            {
                Console.WriteLine("El resultado es verdadero");
                //En caso de que sea verdadeero
            }else
            {
                 Console.WriteLine("El resultado es falso");
                //En caso de ser falso
            }
            //OPERADOR TERNARIO
            var resultado=condicion?"verdadero":"falso";
            Console.WriteLine("Resultado es: "+resultado);

            //EJECUTA LA SENTENCIA VERDADERA
            int x=20, y=10;
            var result =x > y ? "x es mayor que y": "x es menor que y";
            Console.WriteLine(result);
            //EJECUTA LA SENTENCIA FALSA
            x=10;
            y=100;
            result = x> y ? "y es mayor que y" : "x es menor que y";
            Console.WriteLine(result);

            //OPERADOR TERNARIO ANIDADO
            x=100;
            y=10;
            /*result = x>y ? "y es mayor que y":
                         x<y ? "x es menor que y":
                                x == y ? "x es igual a y" : "No hay resultado";*/
            result = x>y ? (x%y==0? "x es mayor que y y son divisibles": "x es solo mayor que y") : (x<y ? "x es menor que y": x == y ? "x es igual a y" : "No hay resultado");                    
            Console.WriteLine(result);

            //OPERADOR TERNARIO CON MÉTODOS
            result=ValidarXMayorQueY(x,y) ? obtenerMensajeMayorX() : obtenerMensajeMenorX();
            Console.WriteLine(result);
        }
        public static bool ValidarXMayorQueY(int x,int y)
        {
            return x>y;
        }
        public static string obtenerMensajeMayorX()
        {
            return "x es mayor que y";
        }
        public static string obtenerMensajeMenorX()
        {
            return "x es menor que y";
        }
    }
}