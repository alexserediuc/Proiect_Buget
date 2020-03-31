using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_Buget;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddStudent(Venit v);
        Student[] GetStudenti(out int nrStudenti);
    }
}
