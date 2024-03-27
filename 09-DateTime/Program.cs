using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tomando datos por default
            DateTime dt = new DateTime();
            Console.WriteLine("El valor de dt1 es {0}", dt);

            //Asignando año, mes y día
            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine("El valor de dt2 es {0}", dt2);

            //Asignando fecha y hora
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine("El valor de dt3 es {0}", dt3);

            //Asignando fecha, hora y zonan horaria UTC
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine("El valor de dt2 es {0}", dt4.ToLocalTime());

            //Excepciones

            try
            {
                DateTime dt5 = new DateTime(2015, 12, 32);
            } catch (Exception ex)
            {
                Console.WriteLine("Hubo un error de conversión: {0}", ex);
            }

            //Ticks 
            DateTime dt6 = new DateTime(636370000000000000);
            Console.WriteLine("El valor de dt6 es {0}", dt6);

            Console.WriteLine("La fecha mínima es {0}", DateTime.MinValue);
            Console.WriteLine("El ticks de la fecha mínima es: {0}", DateTime.MinValue.Ticks);

            Console.WriteLine("La fecha máxima que se puede establecer es: {0}", DateTime.MaxValue);
            Console.WriteLine("El Ticks correspondiente a la fecha máxima es: {0}", DateTime.MaxValue.Ticks);

            //Campos Estáticos
            DateTime fechaHoraActual = DateTime.Now;
            Console.WriteLine("El valor de fechaHoraActual es: {0}", fechaHoraActual);

            DateTime fechaActual = DateTime.Today;
            Console.WriteLine("El valor de fechaActual es: {0}", fechaActual);

            DateTime fechaHoraActualUTC = DateTime.UtcNow;
            Console.WriteLine("El valor de fechaHoraActualUTC es: {0}", fechaHoraActualUTC);

            DateTime fechaHoraMinima = DateTime.MinValue;
            Console.WriteLine("El valor de fechaHoraMinima es: {0}", fechaHoraMinima);  

            DateTime fechaHoraMaxima = DateTime.MaxValue;
            Console.WriteLine("El valor de fechaHoraMaxima es: {0}", fechaHoraMaxima);

            //Intervalos de tiempo
            //Suma
            DateTime dt7 = new DateTime(2015, 12, 31);

            TimeSpan ts = new TimeSpan(25, 20, 55);

            DateTime NuevaFechaHora = dt7.Add(ts);//a  dt7 le suma el valor de ts que es un día con 1 hora 20 min y 55 seg

            Console.WriteLine("El valor de NuevaFechaHora es: {0}",NuevaFechaHora);
            //Resta
            DateTime dt8 = new DateTime(2015, 12, 31);
            DateTime dt9 = new DateTime(2016, 2, 2);
            TimeSpan result = dt9.Subtract(dt8);//33.00:00:00
            Console.WriteLine("El valor de ts2 es: {0} ", result);

            //Días transcurridos desde mi nacimiento
            DateTime fechaNAcimiento = new DateTime(2017,10,17,12,04,00);
            Console.WriteLine("Días transcurridos desde el nacimiento de Mari: {0}", DateTime.Now.Subtract(fechaNAcimiento));

            //Operadores
            DateTime dt11 = new DateTime(2015, 12, 20);
            DateTime dt12 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt12 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt12 - dt11); //377.05:10:20
            Console.WriteLine(dt11 == dt12); //False
            Console.WriteLine(dt11 != dt12); //True
            Console.WriteLine(dt11 > dt12); //False
            Console.WriteLine(dt11 < dt12); //True
            Console.WriteLine(dt11 >= dt12); //False
            Console.WriteLine(dt11 <= dt12);//True

            //Conversión de cadena a DateTime
            //Conversión con TryParce
            var str = "5/12/2020";
            DateTime dt13;

            var isValidDate = DateTime.TryParse(str, out dt13);

            if (isValidDate)
                Console.WriteLine(dt13);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //Conversión con Parse
            try
            {
                DateTime dt14 = DateTime.Parse(str);
                Console.WriteLine("La fecha convertida es: {0}",dt14);
            }
            catch
            {
                Console.WriteLine($"{str} no es una fecha válida");
            }

        }
    }
}
