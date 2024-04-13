namespace _18_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operaciones aritméticas
            int x = 5 + 5;
            int y = x + 5;
            int z = x + y;
            float f = 3.5f + 500000000000L;
            string greet = "Hello" + " World";
            long a = 10000L * 10000L;
            double d = 4.5d;


            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("z = {0}", z);
            Console.WriteLine("f = {0}", f);
            Console.WriteLine("greet = {0}", greet);

            //Operaciones aritméticas con módulo
            int resultado = 11 % 2;
            Console.WriteLine(resultado);

            //Operación unaria
            int b = 5;
            b++;
            int c = b++;
            int e = ++b;
            
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(e);

            //Operación Abreviada o Compuesta
            int h = 10;
            h += 5; //Equivalente a h = h + 5;
            Console.WriteLine(h);
            h -= 5;    //Equivale a  h = h - 5 ;
            Console.WriteLine(h);
            h *= 5;   //Equivalente a h = h * 5
            Console.WriteLine(h);
            h /= 5;   //Equivale a h = h / 5;
            Console.WriteLine(h);

            //Operación de Asignación nula
            string str = "Hello World";
            str ??= "Hola Mundo!";
            Console.WriteLine(str);

            //Operadores de Comparación
            int j = 10;
            int i = 5;
            bool resultado1 = false;

            resultado1 = j < i;
            Console.WriteLine(resultado1);
            resultado1=j> i;
            Console.WriteLine(resultado1);
            resultado1 = j >= i;
            Console.WriteLine(resultado1);
            resultado1 = j <= i;
            Console.WriteLine(resultado1);
            resultado1 = j == i;
            Console.WriteLine(resultado1);
            resultado1 = j != i;
            Console.WriteLine(resultado1);

            //OPERACIÓN DE NEGACIÓN
            Console.WriteLine("Operación de Negación");
            bool bvar = false;
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            Console.WriteLine(!bvar);
            Console.WriteLine(!(5 > 3));

            //OPERACIÓN LÓGICA AND
            Console.WriteLine("Operación Lógica AND");
            bool resultado2 = false;
            resultado2 = OperandoTrue() && OperandoTrue();
            Console.WriteLine(resultado2);
            resultado2 = OperandoTrue() && OperandoFalse();
            Console.WriteLine(resultado2);
            resultado2 = OperandoFalse() && OperandoTrue();
            Console.WriteLine(resultado2);
            resultado2 = OperandoFalse() && OperandoFalse();
            Console.WriteLine(resultado2);

            //Operación Lógica OR
            resultado2 = false;
            resultado2 = OperandoTrue() || OperandoTrue();
            if(resultado2)
                Console.WriteLine(true);
            resultado2 = OperandoTrue() || OperandoFalse();
            if (resultado2)
                Console.WriteLine(true);
            resultado2 = OperandoFalse() || OperandoTrue();
            if (resultado2)
                Console.WriteLine(true);
            resultado2 = OperandoFalse() || OperandoFalse();
            if (resultado2)
                Console.WriteLine(false);


            //Evaluación y precedencia de operadores
            int a1 = 5 + 3 * 3;
            float b1 = 5 + 3 * 3 / 2f;
            int c1 = (5 + 3) * 3 / 2;
            int d1 = (3 * 3) * (3 / 3 + 5);

            Console.WriteLine($"a1 = {a1}");
            Console.WriteLine($"b1 = {b1}");
            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"d1 = {d1}");
        }
        private static bool OperandoTrue()
        {
            return true;
        }
        private static bool OperandoFalse()
        {
            return false;
        }
    }
}
