using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;
        private string nomeRettangolo;

        //costruttore
        public Rettangolo(int @base , int altezza , string name)
        {
            this.baseRettangolo = @base;
            this.altezzaRettangolo = altezza;
            this.nomeRettangolo = name;
        }

        public int calcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public double calcolaPerimetro()
        {
            int perimetro = baseRettangolo * 2 + altezzaRettangolo * 2;
            return perimetro;
        }


        public void StampaRettangolo()
        {
            Console.WriteLine(" rettangolo: {0}", nomeRettangolo);
            Console.WriteLine("base: {0} cm", baseRettangolo);
            Console.WriteLine("altezza: {0} cm", altezzaRettangolo);
            Console.WriteLine("Perimetro: {0} cm", calcolaPerimetro());
            Console.WriteLine("Area: {0} cm", calcolaArea());
            Console.WriteLine();
        }

        //bonus
        public void disegna()
        {
            Console.Write("+");
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");

            for (int i = 1; i < (altezzaRettangolo - 1); ++i)
                Console.WriteLine("|{0}|", new String(' ', (int)(baseRettangolo - 2)));

            Console.Write("+");
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");
        }
    }
}
