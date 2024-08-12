using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populoInheritanceÚkol
{
    internal class Pecivo : Potraviny
    {
        protected string druh;

        public Pecivo(string nazev, float vaha, int cena, string druh) : base(nazev, vaha, cena)
        {
            this.druh = druh;
        }

        public override string ToString()
        {
            return base.ToString() + ", je to " + druh + " pečivo";
        }
    }
}
