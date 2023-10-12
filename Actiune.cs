using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Actiune : ICloneable, IComparable<Actiune>
    {
        private string denumire;
        private double pretUnitar;
        private double cantitate;
        private double valoare;

        public Actiune() { }

        public Actiune(string denumire, double pretUnitar, double cantitate)
        {
            this.denumire = denumire;
            this.pretUnitar = pretUnitar;
            this.cantitate = cantitate;
            this.valoare = CalculValoare();
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public double PretUnitar { get => pretUnitar; set => pretUnitar = value; }
        public double Cantitate { get => cantitate; set => cantitate = value; }
        public double Valoare { get => valoare; }




        public object Clone()
        {
            return new Actiune(Denumire, PretUnitar, Cantitate);
        }

        public int CompareTo(Actiune other)
        {
            return denumire.CompareTo(other.denumire);
        }

        public static bool operator <(Actiune a1, Actiune a2)
        {
            return a1.PretUnitar < a2.PretUnitar;
        }

        public static bool operator >(Actiune a1, Actiune a2)
        {
            return a1.PretUnitar > a2.PretUnitar;
        }

        public double CalculValoare()
        {
            double val = 0;
            val = this.PretUnitar * this.cantitate;
            return val;
        }

        public string returnStringValoare()
        {
            return Convert.ToString(CalculValoare());
        }
        public override string ToString()
        {
            return this.denumire;
        }
    }
}
