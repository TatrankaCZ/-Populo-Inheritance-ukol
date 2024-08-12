using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populoInheritanceÚkol
{
    internal class MlecnyVyrobek : Potraviny
    {
        protected float tuk;

        public MlecnyVyrobek(string nazev, float vaha, int cena, float tuk) : base(nazev,vaha,cena) 
        {
            this.tuk = tuk;
        }

        public override string ToString()
        {
            return base.ToString() + ", Obsahuje " + tuk + "% tuku";
        }
    }
}
