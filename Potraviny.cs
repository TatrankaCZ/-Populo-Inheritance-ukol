using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populoInheritanceÚkol
{
    internal class Potraviny
    {
        protected string nazev;
        protected float vaha;
        protected int cena;

        protected Potraviny(string nazev, float vaha, int cena) 
        {
            this.nazev = nazev;
            this.vaha = vaha;
            this.cena = cena;
        }

        public string GetNazev()
        {
            return this.nazev;
        }

        public float GetVaha()
        {
            return this.vaha;
        }

        public int GetCena()
        {
            return this.cena;
        }

        public override string ToString()
        {
            return "Název: " + this.nazev + ", Váha: " + this.vaha + "kg, Cena: " + this.cena + "CZK";
        }
    }
}
