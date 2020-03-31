using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Buget
{
    class Cheltuiala
    {
        string destinatie;
        string moneda;
        int suma = 0;

        public Cheltuiala()
        {
          
        }

        public void SetCheltuiala(string _valoare)
        {
            int _suma = Int32.Parse(_valoare);
            if (GestiuneEntitati.ValideazaSuma(_suma))
                suma = suma + _suma;
            else
                suma = 0;
        }

        public void SetDestinatie(string _destinatie)
        {
            destinatie = _destinatie;
        }

        public void SetMoneda(string _moneda)
        {
            moneda = _moneda;
        }

        public int GetCheltuiala()
        {
            return suma;
        }

        public void SetCheltuiala(int _suma)
        {
            suma = _suma;
        }

        public string ConversieLaSir()
        {
            string s = string.Format("Cheltuielile sunt de {0} {1}", suma, moneda);
            return s;
        }
    }
}
