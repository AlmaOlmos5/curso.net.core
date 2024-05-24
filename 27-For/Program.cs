namespace _27_For
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola...");
            //BUCLE FOR
            for(int i=0;i<10;i++)
            {
                Console.WriteLine($"El valor de i es: {i}");
            }
            //BUCLE FOR DE UNA SOLA SENTENCIA Y SIN LLAVES
            Console.WriteLine("Bucle for de una sola sentencia");
            for(int i=0; i<10;i++)
                Console.WriteLine($"El valor de i es {i}");
            //BUCLE FOR INFINITO CON INICIALIZADOR, CONDICIÓN, INCREMENTO Y ROMPIMIENTO FUERA DE LA ESTRUCTURA
            Console.WriteLine("Bucle infinito con inicializador, incremento y rompimiento fuera de la estructura");
            int j=0;
            for (; ;)
            {
                 if (j < 10)
                {
                    Console.WriteLine($"El valor de j {j}");
                    j++;
                }else
                    break;
            }
            /*Bucle infinito
            for (; ;)
            {
                Console.WriteLine(1);
            }
           */
           //CICLO FOR CON DOUBLE
           Console.WriteLine("Ciclo for con double");
           for(double i=1.01D;i<1.8D;i+=0.01D)
           {
                Console.WriteLine($"El valor de i: {i}");
           }
           //DOUBLE CON DECREMENTO
           Console.WriteLine("Ciclo for con decremento");
            for(int i=10;i>0;i--)
            {
                Console.WriteLine($"El valor de i es: {i}");
            }
            //BUCLE FOR CON SENTENCIA BREAK PARA ROMPER EL CICLO
            Console.WriteLine("Bucle for con sentencia break para romper el ciclo");
            for(int i=0;i<10;i++)
            {
                if(i==5)
                    break;
                Console.WriteLine($"Valor de i: {i}");
            }
            //BUCLE FOR CON EXPRESIONES MÚLTIPLES
            Console.WriteLine("Bucle for con expresiones múltiples");
            for(int i=0, k=0 ; i+k<5 ; i++,k++)
            {
                Console.WriteLine($"Valor de i: {i} k: {k}");
            }
            //BUCLE CON INSTRUCCIONES EN EL INICIALIZADOR Y EN EL INCREMENTO
            int m=0, n=5;
            for(Console.WriteLine($"Inicializacion m: {m}, n: {n}"); m++ < n--;Console.WriteLine($"iterando m = {m}, n= {n}") )
            {
                Console.WriteLine($"El valor de m: {m}, n:{n}");
            }
            //BUCLE ANIDADO
            for(int i=0; i<2 ; i++)
            {
                for(int h=0; h<4; h++)
                {
                    Console.WriteLine($"Valor de i: {i}, h:{h}");
                }
            }
            //PINTAR ESTRELLAS LINEAL
            PintarEstrellasLineal();
            Console.WriteLine("\n-------------");
            //PINTAR ESTRELLAS VERTICAL
            PintarEstrellasVertical();
            Console.WriteLine("--------");
            //PINTAR TRIÁNGULO
            PintarPino();
            //PINTAR TRIANGULO INVERTIDO
            PintarTrianguloInvertido();
        }
        public static void PintarEstrellasLineal()
        {
            int numEstrellas=10;
            for(int i=1; i<=numEstrellas; i++)
            {
                Console.Write("*");
            }
        }
        public static void PintarEstrellasVertical()
        {
            int numEstrellas=10;
            for(int i=1; i<=numEstrellas; i++)
            {
                Console.WriteLine("*");
            }
        }
        public static void PintarPino()
        {
            int numLineas=10;
            for(int i=1; i<numLineas; i++)
            {
                for(int a=1; a<=i ; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void PintarTrianguloInvertido()
        {
            int numLin=10;
            for(int i=numLin; i>=1; i--)
            {
                for(int a=1; a<=i ; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}