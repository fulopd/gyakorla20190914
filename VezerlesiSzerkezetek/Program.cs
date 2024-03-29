﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezerlesiSzerkezetek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Elágazások: If-else
            Console.WriteLine("Kérem irja be hogy true: ");
            var input = Console.ReadLine();
            bool ertek; //igaz-hamis
            // ha input = "true"
            bool.TryParse(input, out ertek);
            Console.WriteLine(ertek);

            if (ertek)
            {
                Console.WriteLine("A beviteli érték IGAZ");
            }
            else if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("A beviteli érték ÜRES");
            }
            else
            {
                Console.WriteLine("A beviteli érték HAMIS");
            }

            // ?: Feltételes operátor két válaszúttal
            ertek = bool.TryParse(input, out ertek) ? true : false;
            // ?? Null ellenőrző operátor
            input = null;
            ertek = bool.Parse(input ?? "False");

            #endregion

            #region Elágazások: Switch-case
            Console.WriteLine();
            // Jelenlegi hónap lekérdezése
            int honap = DateTime.Now.Month;
            // honap = 99;

            switch (honap)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Tél van.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz van.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár van.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ősz van.");
                    break;
                default:
                    Console.WriteLine("Ilyen hónap nem létezik");
                    break;
            }

            #endregion

            #region Ciklusok: For
            //string[] feladat = new string[3] {
            //    "kérdés", "megoldás", "válasz"
            //};

            string[] feladat = { "kérdés", "megoldás", "válasz" };

            // Egymásba ágyazott for ciklus
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < feladat.Length; j++)
                {
                    Console.WriteLine(i + "." + feladat[j]);
                }
            }

            #endregion

            #region Ciklusok: Foreach

            Console.WriteLine("\nForeach: ");
            foreach (string item in feladat)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Ciklusok: Do-while
            
            string jelszo = "";
            Console.WriteLine("Kérem adja meg a jelszót:");

            do
            {
                
                var bill = Console.ReadKey(true);

                if (bill.Key != ConsoleKey.Backspace && bill.Key != ConsoleKey.Enter)
                {
                    jelszo += bill.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (bill.Key == ConsoleKey.Backspace && jelszo.Length > 0)
                    {
                        jelszo = jelszo.Substring(0, (jelszo.Length - 1));
                        Console.Write("\b \b"); //törlés konzolnál
                    }
                }               
                

            } while (jelszo != "admin");

            Console.WriteLine("\nsikeres belépés");

            #endregion

            #region Ciklusok: While

            Console.WriteLine("A program 5 mp múlva kilép!");

            DateTime jelen = DateTime.Now;
            DateTime jovo = jelen.AddSeconds(5);

            int temp = jelen.Second;
            while (jelen < jovo)
            {
                jelen = DateTime.Now;
                if (jelen.Second != temp)
                {
                    temp = jelen.Second;
                    Console.WriteLine(jelen);
                }
                
            }
            Environment.Exit(0);
            #endregion


            Console.ReadKey();
        }
    }
}
