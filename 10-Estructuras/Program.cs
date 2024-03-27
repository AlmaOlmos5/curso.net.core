using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate point=new Coordinate();
            Console.WriteLine(point.x);
            point.x = 10;
            point.y= 20;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);

            Coordinate point2 = new Coordinate(10,20);
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);

            //Métodos y propiedades en una estructura
            Coordinate point3 = new  Coordinate();
            point3.SetOrigin();
            Console.WriteLine("El valor de point3.x= {0} ",point3.x); 
            Console.WriteLine("El valor de point3.y = {0}",point3.y);

            //Método GetOrigin
            Coordinate point4 = Coordinate.GetOrigin();
            Console.WriteLine("El valor de point4.x= {0} ", point4.x);  
            Console.WriteLine("El valor de point4.y = {0}", point4.y);


            //Eventos
            Coordinate2 point5 = new Coordinate2();
            point5.CoordinatesChanged += notifica;
            point5.x = 10;
            point5.y = 20;
        }
        static void notifica(int point)
        {
            Console.WriteLine("Coordenada cambiada a {0}", point);
        }
    }
}
