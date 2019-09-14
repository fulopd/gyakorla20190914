using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        // Reiter István: C# programozás lépésről lépésre (24-27.old)
        // Karsa Zoltán: C# programozás - Jegyzet (3. old)
        static void Main(string[] args)
        {
            int a = 2, b = 2; // Előjeles, 32 bites egész szám
            int x; // deklaráció 
            x = 10; // definició

            byte bájt = 250; //Előjel nélkül egész szám (0..255)
            char karakter = 'X'; // Egy UniCode karakter
            bool búúl = true; // Logikai típus, értéke igaz (true, 1)
            // vagy hamis (false, 0)
            búúl = Convert.ToBoolean(0);

            float flóath =  (float)(5/4); // Pontossága: 7 számjegy
            double dábül = 6 / 2.3D; // Pontossága: 15-17 számjegy
            decimal decimál = Convert.ToDecimal(6 / 2.3); // Pontossága: 25-29
            // FONTOS: pénz értékét mindig ebbe tároljuk

            string sztring = "szöveg";
            object obdzsekt = new object(); //Minden más típus őse

            // Tetszőleges változó típus, azonnali értékadás
            var variable = "variable";
            var y = 1;

            // Konstans változó
            const string alma = "alma";

            void Tavasz()
            {
                //alma = "piros alma";
            }

            string semmi = "";
            string nihil = null;

            Console.WriteLine(semmi);
            Console.WriteLine(nihil);

            if (semmi != nihil)
            {
                Console.WriteLine("A null nem egyenértékű a \"\"- jellel!");
            }

            Console.ReadKey();
        }
    }
}
