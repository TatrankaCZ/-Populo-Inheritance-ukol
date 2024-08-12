using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populoInheritanceÚkol
{
    internal class Ovoce : Potraviny
    {
        protected bool slupka;

        public Ovoce(string nazev, float vaha, int cena, bool slupka) : base(nazev, vaha, cena)
        {
            this.slupka = slupka;
        }

        public override string ToString()
        {
            if (slupka == true) 
            {
                return base.ToString() + ", Slupka: ANO";
            }
            else
            {
                return base.ToString() + ", Slupka: NE";
            }
        }
    }
}
