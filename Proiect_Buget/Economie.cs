using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Buget
{
    class Economie
    {
        string scop;
        string moneda;
        int suma = 0;

        public Economie() { }

        public void SetEconomie(string _valoare)
        {
            int _suma = Int32.Parse(_valoare);
            if (GestiuneEntitati.ValideazaSuma(_suma))
                suma = suma + _suma;
            else
                suma = 0;
        }

        public void SetScop(string _scop)
        {
            scop = _scop;
        }

        public void SetMoneda(string _moneda)
        {
            moneda = _moneda;
        }

        public int GetEconomie()
        {
            return suma;
        }

        public void SetEconomie(int _suma)
        {
            suma = _suma;
        }

        public string ConversieLaSir()
        {
            string s = string.Format("Economiile sunt de {0} {1}", suma, moneda);
            return s;
        }
    }

}
