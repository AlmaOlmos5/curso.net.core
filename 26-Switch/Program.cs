using System.Linq.Expressions;

namespace _26_Switch
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            //SWITCH CON UNA VARIABLE
            int x=10;
            switch (x)
            { 
                case 5:
                    Console.WriteLine("El valor de x es 5");
                    break;
                case 10:
                    Console.WriteLine("El valor de x es 10");
                    break;
                case 15:
                    Console.WriteLine("El valor de x es 15");
                    break;
                default:
                    Console.WriteLine("Valor desconocido");
                    break;
            }

            //SWITCH CON UNA EXPRESIÓN
            x=125;
            switch (x%2)
            {
                case 0: 
                Console.WriteLine($"{x} es un valor par");
                break;
                case 1:
                Console.WriteLine($"{x} es un valor impar");
                break;
            }
            //SWITCH CON UNA CADENA
            string tipoSentencia= "switch";
            switch(tipoSentencia)
            {
                case "if.else":
                    Console.WriteLine("sentencia if...else");
                    break;
                case "ternary":
                    Console.WriteLine("Operador ternario");
                    break;
                case "switch":
                    Console.WriteLine("Sentencia switch");
                    break;
            }

            //COMBINACIÓN DE CASOS CON SENTENCIA SWITCH
             x = 4;

            switch (x)
            { 
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;
            }
            //SWITCH CON RETURN
            x=124;
            Console.WriteLine(esImpar(x)?"Es impar" : "Es par");

            /*SWITCH SIN CASO
            x=1;
            switch (x)
            {
                case 0: 
                    Console.WriteLine($"{x} es valor par");
                    break;
                case 1: 
                    Console.WriteLine($"{x} es valor impar");
                    break;
                case 1: //Nos marcará error
                    Console.WriteLine($"{x} es valor impar");
                    break;
                default:
                Console.WriteLine($"{x} esImpar valor impar");
                break;
            }*/

            //SWITCH ANIDADOS
            int j=5;
            switch(j = 5)
            {
                case 5: 
                    Console.WriteLine($"El valor de j es {j}");
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3: 
                                    Console.WriteLine(3);
                                    break; 
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15: 
                    Console.WriteLine(15);
                    break; 
                default:
                    Console.WriteLine(100);
                    break;
            }
            switch(obtenerValor())
            {
                case 0: 
                    Console.WriteLine("El valor es 0");
                    break;
                case 1: 
                    Console.WriteLine("El valor es 1");
                    break;
            }
            MenuCajero();
            Console.Read();
        }
        static bool esImpar(int x)
        {
            switch(x%2)
            {
                case 0: 
                    return false;
                case 1: 
                    return true;
            }
            return false;
        }
        static int obtenerValor()
        {
            Random rnd= new Random();
            return rnd.Next(0,2);
        }
        static void MenuCajero()
        {
            Console.WriteLine("Introduce el número de tarjeta");
            int numTarjeta = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el NIP");
            int nip=int.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona la operación que desea realizar");
            Console.WriteLine("1.- Retirar Efectivo");
            Console.WriteLine("2.- Consultar Saldo");
            Console.WriteLine("3.- Incrementar línea de crédito");
            Console.WriteLine("4.- Compra de tiempo aire");
            Console.WriteLine("5.- Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    RetirarDinero();
                    break; 
                case 2: 
                    ConsultarSaldo();
                    break; 
                case 3: 
                    IncrementarLineaCredito();
                    break;
                case 4: 
                    ComprarTiempoAire();
                    break;
                case 5: 
                    Salir();
                    break;
            }
        }
        public static void RetirarDinero()
        {
            Console.WriteLine("Retirar Dinero");
        }
        public static void ConsultarSaldo()
        {
            Console.WriteLine("Consultar saldo");
        }
        public static void IncrementarLineaCredito()
        {
            Console.WriteLine("Incrementar línea de crédito");
        }
        public static void ComprarTiempoAire()
        {
            Console.WriteLine("Comprar tiempo aire");
        }
        public static void Salir()
        {
            Console.WriteLine("Saliendo...");
        }
    }
}