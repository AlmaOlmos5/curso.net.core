namespace _30_Arrays
{
    internal class Program
    {
        static void Main (string[] args)
        {
            //DECLARACIÓN E INICIALIZACIÓN DE ARREGLOS
            /*
            int[] evenNums=new int [5] {2, 4, 6, 8, 10};
            string[] cities = new string[3]{ "Mumbai", "London", "New York" };
            */

            //INICIALIZACIÓN TARDÍA
           /* int[] evenNums;
            evenNums = new int[5];
            evenNums = new int[]{ 2, 4, 6, 8, 10 };*/
            //ACCESO A LOS ELEMENTOS DE LA MATRIZ MEDIANTE INDICES
            int[] evenNums = new int[5];
            evenNums[0] = 2;
            evenNums[1] = 4;
            //evenNums[6] = 12;  ERROR PORQUE ESTÁ FUERA DEL RANGO
            Console.WriteLine(evenNums[0]);  
            Console.WriteLine(evenNums[1]);  

            //ACCESO A LA MATRIZ MEDIANTE CICLO FOR
            int[] evenNums2 = {2, 4, 6, 8, 10 };

            for(int i = 0; i < evenNums2.Length; i++)
                Console.WriteLine(evenNums2[i]);  

            for(int i = 0; i < evenNums2.Length; i++)
            {
                evenNums2[i] = evenNums2[i] + 10; 
                Console.WriteLine($"El nuevo valor de i: {evenNums2[i]}");
            }
            //Acceso a la matriz mediante el bucle foreach
            Console.WriteLine("Acceso a matriz mediante foreach");
            string[] cities = { "Mumbai", "London", "New York" }; 

            foreach(var item in evenNums2)
                Console.WriteLine(item);   

            foreach(var city in cities)
                Console.WriteLine(city);  

            //MÉTODOS LINQ
            Console.WriteLine("Métodos LINQ");
            Console.WriteLine($"El máximo es: {evenNums2.Max()}");
            Console.WriteLine($"El mínimo es: {evenNums2.Min()}");
            Console.WriteLine($"La suma es: {evenNums2.Sum()}");
            Console.WriteLine($"El promedio es: {evenNums2.Average()}");
            //MÉTODOS ARRAY
            Console.WriteLine("Métodos array");
            Array.Sort(evenNums2);
            Array.ForEach(evenNums2, item => Console.WriteLine(item));

            //PASAR MATRIZ COMO UN ARGUMENTO 
            Console.WriteLine("Matriz como argumento");
            int[] nums = { 1, 2, 3, 4, 5 };
            UpdateArray(nums); 

            foreach(var item in nums)
            Console.WriteLine(item);  

            //EJEMPLO DE APLICACIÓN CON LA BÚSQUEDA DEL MÁXIMO DE UN ARREGLO
            Console.WriteLine("-------Máximo------"); 
            Maximo();
            Console.WriteLine("-------Suma------"); 
            Console.WriteLine(Suma());
        
        }
        public static void UpdateArray(int[] arr)
        {
                    for(int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] + 10;   
        }
        public static void Maximo()
        {
            //1.- inicio
            //2.- Declarar e inicializar arreglo
            int[] numeros={-44, -23, -60, -50, -40, -2, -8, -70, -55, 44,23, 60, 50, 40, 2, 8, 70, 55};
            //3.- Declarar e inicializar la variable maximo con el valor minimo de enteros.
            int maximo= int.MinValue;
            //4.- Iterar el arreglo for
            for(int i=0; i< numeros.Length; i++)
            {
                //Por cada elemento del arreglo comparar si es mayor que la variable maximo
                int elemento=numeros[i];
                if(elemento>maximo)
                {
                    //Si es mayor, asignar el valordel arreglo a la variable maximo
                    maximo=elemento;
                }
                
                //Si no, no hace algo.
            }
            Console.WriteLine(maximo);
        }

        public static int Suma()
        {
            //1.- inicio
            //2.- Declarar e inicializar arreglo
            int[] numeros={-44, -23, -60, -50, -40, -2, -8, -70, -55, 44,23, 60, 50, 40, 2, 8, 70, 55};
            int suma= 0;
            //4.- Iterar el arreglo for
            foreach(int elemento in numeros)
            {
                suma+=elemento;
            }
            return suma;
        }

    }
}