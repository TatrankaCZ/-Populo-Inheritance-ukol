using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace populoInheritanceÚkol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vytvoření dvou typů od každého s unikátním parametrem
            Ovoce banan = new Ovoce("Banán", 0.2f, 30, true);
            Ovoce jablko = new Ovoce("Jablko", 0.12f, 25, false);

            Pecivo rohlik = new Pecivo("Rohlík", 0.04f, 3, "slané");
            Pecivo croissant = new Pecivo("Croissant", 0.06f, 10, "sladké");

            MlecnyVyrobek jogurt = new MlecnyVyrobek("Jogurt", 0.2f, 20, 3.5f);
            MlecnyVyrobek syrEidam = new MlecnyVyrobek("Eidam", 2.7f, 100, 30f);

            // Uložení všeho do společného seznamu
            Potraviny[] potraviny = { banan, jablko, rohlik, croissant, jogurt, syrEidam };

            // Vypsání a nákup
            foreach (Potraviny x in potraviny)
            {
                Console.WriteLine(x.ToString() + "\n");
            }

            Console.WriteLine();

            List<Tuple<Potraviny, int>> seznam = new List<Tuple<Potraviny, int>>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Vyberte si potravinu číslo " + (i + 1) + ": ");
                string temp = Console.ReadLine();
                foreach (Potraviny x in potraviny)
                {
                    if (temp == x.GetNazev())
                    {
                        Console.Write("Kolik chcete kusů?: ");
                        int temp2 = int.Parse(Console.ReadLine());
                        seznam.Add(new Tuple<Potraviny, int>(x, temp2));
                        Console.WriteLine();
                    }
                }
            }

            int totalCena = (seznam[0].Item1.GetCena() * seznam[0].Item2) + (seznam[1].Item1.GetCena() * seznam[1].Item2) + (seznam[2].Item1.GetCena() * seznam[2].Item2);
            float totalVaha = (seznam[0].Item1.GetVaha() * seznam[0].Item2) + (seznam[1].Item1.GetVaha() * seznam[1].Item2) + (seznam[2].Item1.GetVaha() * seznam[2].Item2);

            Console.WriteLine("Váš nákup stojí " + totalCena + " korun a váží " + totalVaha + "kg.");


            Console.ReadLine();
        }
    }
}
