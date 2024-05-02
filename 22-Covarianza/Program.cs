
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Covarianza
{
    internal class Program
    {
        public delegate Small covarDelegado(Big mc);
        static void Main(string[] args)
        {
            Small small = new Small();
            small.id = 1;
            small.nombre = "Juan";

            Big big = new Big();
            big.id = 2;
            big.nombre = "María";
            big.Descripcion = "Persona grande";

            Bigger bigger = new Bigger();
            bigger.id = 3;
            bigger.nombre = "Pedro";
            bigger.Descripcion = "Persona extra grande";
            bigger.tamanio = 2.30f;

            //Creación de objetos y asignarlos a variables.
            Small small1=new Small();
            Small small2=new Big();
            Small small3=new Bigger();

            Big big1= new Bigger();

            //Big big 2=new Small(); Muestra error porque no se puede asignar un objeto más chico a uno más grande.

            covarDelegado del1 = Method1;
            Small sm1 = del1(new Big());

            covarDelegado del2 = Method2;
            Small sm2 = del2(new Big());

            covarDelegado del3 = Method3;
            Small sm3 = del3(new Big());

            covarDelegado del4 = Method2;
            //Small sm4 = del4(new Big());

            covarDelegado del5 = Method4;
            Small sm5 = del5(new Big());

            covarDelegado del = Method1;
            del += Method2;
            del += Method3;
            del += Method4;

            Small small5 = del(new Big());

            covarDelegado del6 = Method5;
            Small sm6 = del6(new Big());
        }
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }
        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }
        public static Bigger Method3 (Big bg)
        {
            Console.WriteLine("Method3");

            return new Bigger();
        }
        public static Small Method4(Small sml)
        {
            Console.WriteLine("Method4");

            return new Small();
        }
        public static Big Method5(Small sml)
        {
            Console.WriteLine("Method5");

            return new Big();
        }
    }
    public class Small
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Big : Small
    {
        public string Descripcion { get; set; }
    }

    public class Bigger: Big
    {
        public float tamanio {  get; set; }
    }
}
