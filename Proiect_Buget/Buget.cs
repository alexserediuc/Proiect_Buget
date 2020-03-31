using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Buget
{
    public static class Buget
    {
        public static int GetSumaDisponibila(int v, int e, int c)
        {
            int sumaDisponibila;

            sumaDisponibila = v + e - c;

            return sumaDisponibila;
        }
    }


}
