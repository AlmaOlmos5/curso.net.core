using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace _12_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder(); //El string se agregará más tarde
            StringBuilder sb = new StringBuilder("Hello World!");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Hola Mundo!", 50);//Colocando la cantidad de caracteres máx.
            Console.WriteLine(sb1);
            
            //vamos a iterar para obtener los caracteres 
            StringBuilder sb2 = new StringBuilder("Hola amigos!");

            for (int i = 0; i < sb2.Length; i++)
            {
                Console.Write(sb2[i]);
                Console.WriteLine("\n");
            }

            //Recuperar la cadena StringBuilder
            var greet = sb.ToString();
            Console.WriteLine(greet);

            //Agregar/anexar cadena a StringBuilder
            StringBuilder sb3= new StringBuilder();
            sb3.Append("Hello ");
            sb3.AppendLine("World!");
            sb3.AppendLine("Hello C#");
            Console.WriteLine(sb3);

            //Anexar cadena formateada a StringBuilder
            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C} ", 25);

            Console.WriteLine(sbAmout);


            //Insertar cadena en StringBuilder
            sb.Insert(5, " C#");

            Console.WriteLine(sb); //output: Hello C# World!

            //Eliminar cadena en StringBuilder
            StringBuilder sb5 = new StringBuilder("Hello World!", 50);
            sb5.Remove(6, 6);

            Console.WriteLine(sb5); //output: Hello

            //Reemplazar cadena en StringBuilder
            StringBuilder sb6 = new StringBuilder("Hello World!");
            sb6.Replace("World", "C#");

            Console.WriteLine(sb6);//output: Hello C#!
        }
    }
}
