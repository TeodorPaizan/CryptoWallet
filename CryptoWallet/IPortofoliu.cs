using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal interface IPortofoliu
    {
        void AdaugaActiune(Actiune actiune);
        void StergeActiune(Actiune actiune);
        void AfiseazaPortofoliu();
    }
}
