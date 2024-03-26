using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "S";
            string word = "String";
            string text = "This is a string.";

            string str1 = "Hello"; // usando la palabra clave string

            String str2 = "Hello"; // usando la clase System.String 

            //--------------------------
            char[] chars = { 'H', 'o', 'l', 'a' };

            string str11 = new string(chars);
            String str12 = new String(chars);

            foreach (char caracter in str11)
            {
                Console.WriteLine(caracter);
            }
            // ---------------------------------------------------------------
            //Caracteres especiales
            string text1 = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";
            string saltoLin = "Hola\nMundo";

            Console.WriteLine(text1);
            Console.WriteLine(str);
            Console.WriteLine(path);
            Console.WriteLine(saltoLin);

            // -------------------------------------------
            string str3 = @"xyzdef\rabc";
            string path3 = @"\\mypc\shared\project";
            string email = @"test@test.com";

            Console.WriteLine(str3);
            Console.WriteLine(path3);
            Console.WriteLine(email);

            // ---------------------------------------------------------
            //Varias Líneas
            string str4 = "this is a \n" +
            "multi line \n" +
            "string";

            // Verbatim string
            string str5 = @"this is a 
            multi line 
            string";
            Console.WriteLine(str4);    
            Console.WriteLine(str5);

            //__________________________________________________________
            string text3 = "This is a \"string\" in C#."; // válido
           // string text = @"This is a "string." in C#."; // error
           // string text = @"This is a \"string\" in C#."; // error
            string text4 = @"This is a ""string"" in C#."; // válido

            Console.WriteLine(text3);
            Console.WriteLine(text4);
            //______________________________________________________
            //Concatenación de cadenas
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;
            Console.WriteLine(agent);
            //________________________________________________
            //Interpolación
            string firstName1 = "James";
            string lastName1 = "Bond";
            string code1 = "007";

            string fullName = $"Mr. {firstName1} {lastName1}, Code: {code1}";
            Console.WriteLine(fullName);
        }
    }
}
