using System;
namespace csharp_geometria{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valore1,valore2;
            Console.WriteLine("inserire valore base  rettangolo");
            if (!int.TryParse(Console.ReadLine(), out valore1))
            {
                Console.WriteLine("Non hai inserito un numero");
                Environment.Exit(1);

            }
            Console.WriteLine("inserire valore altezza rettangolo");
            if (!int.TryParse(Console.ReadLine(), out valore2))
            {
                Console.WriteLine("Non hai inserito un numero");
                Environment.Exit(1);

            }

            Console.WriteLine("inserire nome Rettangolo");
            string nome1 = Console.ReadLine();


            Rettangolo Rettangolo1 = new Rettangolo(valore1, valore2,nome1);
            Rettangolo1.StampaRettangolo();
            Rettangolo1.disegna();


            //Rettangolo Rettangolo2 = new Rettangolo(30, 40);
            //Rettangolo2.calcolaPerimetro();
            //Rettangolo2.calcolaArea();
            int valore3, valore4;
            Console.WriteLine("inserire valore base  rettangolo");
            if (!int.TryParse(Console.ReadLine(), out valore3))
            {
                Console.WriteLine("Non hai inserito un numero");
                Environment.Exit(1);

            }
            Console.WriteLine("inserire valore altezza rettangolo");
            if (!int.TryParse(Console.ReadLine(), out valore4))
            {
                Console.WriteLine("Non hai inserito un numero");
                Environment.Exit(1);

            }
            Console.WriteLine("inserire nome Rettangolo");
            string nome2 = Console.ReadLine();
            Rettangolo Rettangolo2 = new Rettangolo(valore3, valore4,nome2);
            Rettangolo2.StampaRettangolo();
            Rettangolo2.disegna();

        }
    }

    }