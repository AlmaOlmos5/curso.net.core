namespace _24_StatementsIf
{
    class Program
    {
        static void Main(String[] args)
        {
            int i = 10;
            int j = 20;
            if (i < j)
            {
                Console.WriteLine("i es menor que j");
            }
            if (j > i)
            {
                Console.WriteLine("j es mayor que i");
            }

            //Error 
            /*int i = 10, j = 20;

            if (i + 1)
            {
                Console.WriteLine("i is less than j");
            }        

            if (i + j)
            {
                Console.WriteLine("i is greater than j");
            }*/

            //DECLARACIONES IF CON FUNCIONES
            int k = 10, l = 20;

            if (isGreater(k, l))
            {
                Console.WriteLine("k es mayor que l");
            }        

            if (isGreater(l, k))
            {
                Console.WriteLine("l es mayor que k");
            }
            //DECLARACIONES if - ELSE IF
            if (i == j)
            {
                Console.WriteLine("i es igual a j");
            }
            else if (i > j)
            {
                Console.WriteLine("i es mayor que j");
            }
            else if (i < j)
            {
                Console.WriteLine("j es mayor que i");
            }
            //DECLARACIONES if- else- if- else
            i = 20;
            j = 20;
            if (i > j)
            {
                Console.WriteLine("i es mayor que j");
            }
            else if (i < j)
            {
                Console.WriteLine("j es mayor que i");
            }
            else
            {
                Console.WriteLine("i es igual a j");
            }
            //DECLARACIONES IF ELSE - IF ANIDADAS
            i=10;
            j=20;
            if(i!=j)
            {
                if (i < j)
                {
                    Console.WriteLine("i es menor que j");
                }
                else if (i > j)
                {
                Console.WriteLine("i es mayor quej");
                }
            }
            determinarMayor();
            determinarMAyorMedioMenor(8,9,40);
        }
        static bool isGreater(int i, int j)
        {
            return i > j;                    
        }
        public static void determinarMayor()
        {
            Console.WriteLine("----Determina Mayor----");
            int a=8, b=6, c=0;
            //1.- Comparar si a es mayor que b
            if (a>b)
            {
                //Comparar si a es mayor que c
                if(a>c)
                {
                    Console.WriteLine("a es el mayor");
                }
                else{
                    Console.WriteLine("c es el mayor");
                }
            }//En caso contrario
            else{
                //Comparar si b > c
                if (b>c)
                {
                    Console.WriteLine("b es mayor ");
                }
            }
        }
        public static void determinarMAyorMedioMenor(int a,int b, int c)
        {
            Console.WriteLine("----Determina Mayor----");
            if(a>b)
            {
                if (b>c)
                {
                    Console.WriteLine("a es el mayor");
                    Console.WriteLine("b es el medio");
                    Console.WriteLine("c es el menor");
                }
                else
                {
                    Console.WriteLine("c es el mayor");
                    Console.WriteLine("a es el medio");
                    Console.WriteLine("b es el menor");
                }
            }
            else{
                if(b>c)
                {
                    if(a>c)
                    {
                        Console.WriteLine("b es el mayor");
                        Console.WriteLine("a es el medio");
                        Console.WriteLine("c es el menor");
                    }
                    else
                    {
                        Console.WriteLine("b es el mayor");
                        Console.WriteLine("c es el medio");
                        Console.WriteLine("a es el menor");
                    }
                }
                else
                {
                    Console.WriteLine("c es el mayor");
                    Console.WriteLine("b es el medio");
                    Console.WriteLine("a es el menor");
                }
            }
        }
        
    } 
    
}