using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Buget
{
    class Venit
    {
        //Date private
        string sursa;
        string moneda;
        int suma = 0;

        //Constructor implicit
        public Venit() 
        {
            
        }

        //Constructor cu parametrii
        public Venit(int _valoare, string _sursa, string _moneda)
        {
            suma = _valoare;
            sursa = _sursa;
            moneda = _moneda;
        }

        public void SetVenit(string _valoare)
        {
            int _suma = Int32.Parse(_valoare);
            if (GestiuneEntitati.ValideazaSuma(_suma))
                suma = suma + _suma;
            else
                suma = 0;
        }

        public void SetSursa(string _sursa)
        {
            sursa = _sursa;
        }

        public void SetMoneda(string _moneda)
        {
            moneda = _moneda;
        }

        public int GetVenit()
        {
            return suma;
        }

        public string GetSursa()
        {
            return sursa;
        }


        public string ConversieLaSir()
        {
            string s = string.Format("Venitul este de {0} {1}", suma, moneda);
            return s;
        }
    }


}
