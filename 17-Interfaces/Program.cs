using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de DB con inferfaces
            //IDBContext DbContext = new SQLDBContext();
            IDBContext DbContext = new OracleDBContext();
            DbContext.insert(new object());
            DbContext.update(new object());
            //Ejemplo de File Infor con interfaces, con la propia clase y Object
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            Object file3= new FileInfo();
            //Interfaces
            file1.ReadFile();
            file1.WriteFile("Hola");
            //Con la propia clase
            file2.ReadFile();
            file2.WriteFile("Hola Mundo");
            Console.WriteLine(file2.fileName);
            file2.fileName = "OtroArchivo.txt";
            Console.WriteLine(file2.fileName);
            //Con la clase Object
            Console.WriteLine(file3);

            IFile file4=new FileInfo2();
            FileInfo2 file5=new FileInfo2();

            file4.ReadFile();
            file4.WriteFile("Hola");
            //file4.Search("Hola"); esto marca erro porque no tiene acceso

            file5.Search("Hola");
            //file5.ReadFile(); //No se puede acceder a los métodos 

            //Ejemplo FileInfo con múltiples interfaces

            IFile file6=new FileInfo3();
            IBinaryFile file7 = new FileInfo3();
            FileInfo3 file8 = new FileInfo3();

            //file6 no puede acceder al método OpenBinaryFile()
            file6.ReadFile();
            file6.WriteFile("Hola");


            file7.ReadFile();
            file7.OpenBinaryFile();

            file8.Search("Hola");
            file8
        }
    }
}
