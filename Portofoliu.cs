using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Portofoliu : ICloneable, IComparable<Portofoliu>, IPortofoliu
    {

        private List<Actiune> listaActiuni;

        public Portofoliu()
        {
            this.listaActiuni = new List<Actiune>();
        }

        public List<Actiune> ListaActiuni { get; set; }

        public object Clone()
        {
            Portofoliu clone = new Portofoliu();
            foreach (Actiune actiune in ListaActiuni)
            {
                clone.ListaActiuni.Add((Actiune)actiune.Clone());
            }
            return clone;
        }

        public int CompareTo(Portofoliu other)
        {
            return ListaActiuni.Count.CompareTo(other.ListaActiuni.Count);
        }

        public static Portofoliu operator +(Portofoliu p1, Portofoliu p2)
        {
            Portofoliu resultat = (Portofoliu)p1.Clone();
            foreach (Actiune actiune in p2.ListaActiuni)
            {
                resultat.ListaActiuni.Add((Actiune)actiune.Clone());
            }
            return resultat;
        }

        public void AdaugaActiune(Actiune actiune)
        {
            listaActiuni.Add(actiune);
        }

        public void StergeActiune(Actiune actiune)
        {
            listaActiuni.Remove(actiune);
        }

        public void AfiseazaPortofoliu()
        {
            foreach (var actiune in listaActiuni)
            {
                Console.WriteLine(actiune.ToString());
            }
        }
    }
}
