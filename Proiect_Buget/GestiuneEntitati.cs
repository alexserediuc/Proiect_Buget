using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Buget
{
    public static class GestiuneEntitati
    {
        public const int SUMA_MINIMA = 1;

        public static bool ValideazaSuma(int suma)
        {
            if (suma < SUMA_MINIMA)
                return false;
            return true;
        }

    }
}
