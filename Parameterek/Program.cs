using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterek
{
    class Program
    {
        static void Main(string[] args)
        {
            Udvozles(); // nézzük meg mi lesz a kimenet
            Udvozles("Hello!"); // ez esetén

            int a = 2, b = 3;

            SzamKiiras(a, b);
            Console.WriteLine("Összadott értékük: " + Osszeadas(a, b));
            Console.WriteLine("A két szám összegének négyzete: " + Hatvany(ref a,ref b));
            SzamKiiras(a, b);

            bool paros;
            int szam = 11;
            Console.WriteLine("A következő szám páros e? " + szam);
            Paros(szam, out paros);
            Console.WriteLine(paros);

            int iNull;
            string sNull = "0";

            int.TryParse(sNull, out iNull);

            Console.ReadKey();
        }

        static void SzamKiiras(int elso, int masodik)
        {
            Console.WriteLine("Első szám értéke: {0}. Második szám: {1}", elso, masodik);
        }

        // Alapértelmezett értékű paraméter
        static void Udvozles(string s = "Szia!")
        {
            Console.WriteLine(s);
        }

        static int Osszeadas(int elso, int masodik)
        {
            return elso + masodik;
        }

        // Referencia szintű paraméterátadás
        static double Hatvany(ref int elso, ref int masodik)
        {
            elso = 3;
            masodik = 4;

            Console.WriteLine();
            // (a+b)^2
            return Math.Pow(elso + masodik, 2);
        }

        // Kimeneti értéket ad meg a paraméter
        static void Paros(int szam, out bool eredmeny)
        {
            //if (szam % 2 == 0)
            //{
            //    eredmeny = true;
            //}
            //else
            //{
            //    eredmeny = false;
            //}

            // ?: operátor
            eredmeny = (szam % 2 == 0) ? true : false;
        }
    }
}
