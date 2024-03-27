using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enumeracion
{
    internal class Enumeraciones
    {
    }
    enum DiasSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado, 
        Domingo
    }
    enum Categories
    {
        Electronics,    // 0
        Food,           // 1
        Automotive = 6, // 6
        Arts,           // 7
        BeautyCare,     // 8
        Fashion         // 9
    }

    enum Categories2:byte
    {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15,
        WomanFashion = 15
    }



}
