using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatekHazi
{
    class Program
    {
        static Random rnd = new Random();
        static int Helyes = 0;
        static int Helytelen = 0;
        static void Main(string[] args)
        {
            MatekHaziFeladat();
            Console.ReadKey();
        }

        private static void MatekHaziFeladat()
        {   
            Console.WriteLine("\n\tKérem válassza ki milyen feladatot szeretne gyakorolni");
            Console.WriteLine("\n\n\t\t1 program: Összeadás");
            Console.WriteLine("\n\n\t\t2 program: Kivonás");
            Console.WriteLine("\n\n\t\t3 program: Szorzás");
            Console.WriteLine("\n\n\t\t4 program: Osztás");
            Console.WriteLine("\n\n");
            int ProgramSorszam = 0;
            do
            {
                Console.Write("\n\n\t\tMelyik feladat típust választotta: ");
                ProgramSorszam = int.Parse(Console.ReadLine());
            } while ( ProgramSorszam < 0 || ProgramSorszam > 4);
            Console.Clear();
            if (ProgramSorszam == 1)
            {
                Osszeadas();
               
            }
            if (ProgramSorszam == 2)
            {
                Kivonas();
            }
            if (ProgramSorszam == 3)
            {
                Szorzas();
            }
            if (ProgramSorszam == 4)
            {
                Osztas();
            }
        }

       

        private static void Kiertekel()
        {
            if (Helyes == 10)
            {
                Console.WriteLine("\n\tÖn kitűnő ebben a játékban");
                Dontes();
            }
            if (Helyes == 9)
            {
                Console.WriteLine("\n\tÖn nagyon jó ebben a játékban");
                Dontes();
            }
            if (Helyes == 8)
            {
                Console.WriteLine("\n\tÖn jó ebben a játékban");
                Dontes();
            }
            if (Helyes == 7)
            {
                Console.WriteLine("\n\tÖn közepesen jó ebben a játékban");
                Dontes();
            }
            if (Helyes == 6)
            {
                Console.WriteLine("\n\tÖn fejlődőképes ebben a játékban");
                Dontes();
            }
            if (Helyes < 6)
            {
                Console.WriteLine("\n\tÖnnek készült ez a program!");
                Dontes();
            }
        }

        private static void Dontes()
        {hiba:
            Console.Write("\n\tKíván újra játszani (Y/N) : ");
            string Valasz = Console.ReadLine().ToLower();
            if (Valasz == "y")
            {
                Console.Clear();
                MatekHaziFeladat();
            }
            if (Valasz == "n")
            {
                Console.Clear();
                Console.ReadKey();
            }
            else
            {
                goto hiba;
            }
        }
        private static void Osztas()
        {
            int db = 0;
            int Szam_1;
            int Szam_2;
            do
            {
                db++;
                Szam_1 = rnd.Next(2, 100);
                Szam_2 = rnd.Next(2, 100);
                int Szorzat_Ertek = Szam_2 * Szam_1;
                Console.Write("\n\n\t\t{0:00}. Feladat -> {1:00}×{2:00}= ", db, Szorzat_Ertek, Szam_1);
                int FelhasznaloValasz = int.Parse(Console.ReadLine());
                if (FelhasznaloValasz == Szam_2)
                {
                    Helyes++;
                    Console.WriteLine("\t\tHelyes");
                }
                else
                {
                    Helytelen++;
                    Console.WriteLine("\t\tHelytelen");
                }

            } while (db < 10);
            Kiertekel();
        }
        private static void Szorzas()
        {
            int db = 0;
            int Szam_1;
            int Szam_2;
            do
            {
                db++;
                Szam_1 = rnd.Next(2, 11);
                Szam_2 = rnd.Next(2, 11);
                int Szorzat_Ertek = Szam_2 * Szam_1;
                Console.Write("\n\n\t\t{0:00}. Feladat -> {1:00}×{2:00}= ", db, Szam_2, Szam_1);
                int FelhasznaloValasz = int.Parse(Console.ReadLine());
                if (FelhasznaloValasz == Szorzat_Ertek)
                {
                    Helyes++;
                    Console.WriteLine("\t\tHelyes");
                }
                else
                {
                    Helytelen++;
                    Console.WriteLine("\t\tHelytelen");
                }

            } while (db < 10);
            Kiertekel();
        }

        private static void Kivonas()
        {
            int db = 0;
            int Szam_1;
            int Szam_2;
            for (int i = 1; i < 11; i++)
            {
                db++;
                Szam_1 = rnd.Next(1, 50);
                Szam_2 = rnd.Next(1, 50);
                if(Szam_1<Szam_2)
                {
                    int Kulonbseg_1 = Szam_2 - Szam_1;
                    Console.Write("\n\n\t\t{0:00}. Feladat -> {1:00}-{2:00}= ", i, Szam_2, Szam_1);
                    int FelhasznaloValasz = int.Parse(Console.ReadLine());
                    if (FelhasznaloValasz == Kulonbseg_1)
                    {
                        Helyes++;
                        Console.WriteLine("\t\tHelyes");
                    }
                    else
                    {
                        Helytelen++;
                        Console.WriteLine("\t\tHelytelen");
                    }
                }
                if (Szam_2 < Szam_1)
                {
                    int Kulonbseg_1 = Szam_1 - Szam_2;
                    Console.Write("\n\n\t\t{0:00}. Feladat -> {1:00}-{2:00}= ", i, Szam_1, Szam_2);
                    int FelhasznaloValasz = int.Parse(Console.ReadLine());
                    if (FelhasznaloValasz == Kulonbseg_1)
                    {
                        Helyes++;
                        Console.WriteLine("\t\tHelyes");
                    }
                    else
                    {
                        Helytelen++;
                        Console.WriteLine("\t\tHelytelen");
                    }
                }
            }
            Kiertekel();
        }

        private static void Osszeadas()
        {
            int Szam_1;
            int Szam_2;
            for (int i = 1; i < 11; i++)
            {
                Szam_1 = rnd.Next(1, 50);
                Szam_2 = rnd.Next(1, 50);
                int Osszeg = Szam_1 + Szam_2;
                Console.Write("\n\n\t\t{0:00}. Feladat -> {1:00}+{2:00}= ", i, Szam_1 , Szam_2);
                int FelhasznaloValasz = int.Parse(Console.ReadLine());
                if (FelhasznaloValasz == Osszeg)
                {
                    Helyes++;
                    Console.WriteLine("\t\tHelyes");
                }
                else
                {
                    Helytelen++;
                    Console.WriteLine("\t\tHelytelen");
                }
            }  
            Kiertekel();
        }
    }
}
