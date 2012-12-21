using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {



        public static bool b = true;

        static void Main(string[] args)
        {  
            string p = "papper";
            while (b == true)
            {
                countTries = 0;
                Hangman(p);

                if (b == false)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
        public static int countTries;
        public static bool Hangman(string p)
        {
            char inMat;
            string doldBokstav = "";
            string compare;
            int count = 0;

            foreach (char c in p)
            {
                doldBokstav += "*";
            }
            compare = doldBokstav;
            
            while (true)
            {
                Console.WriteLine("Välj en bokstav:");
                inMat = Console.ReadKey().KeyChar;
              //  Console.ReadKey();
                Console.Clear();
                foreach (char c in p)
                {
                    if (c == inMat)
                    {
                        doldBokstav = doldBokstav.ToLower().Substring(0, count) + inMat + doldBokstav.ToLower().Substring(count + 1, p.Length - (count + 1));
                    }

                    count++;
                }
                if (compare == doldBokstav)
                {
                    countTries++;
                }
                else
                {
                    compare = doldBokstav;
                }
                if (!doldBokstav.Contains('*'))
                {
                    Console.WriteLine("Win!\nPlay Again? (y/n)");
                    if (Console.ReadKey().KeyChar == 'n')
                    {
                        Environment.Exit(0);
                    }
                    Console.Clear();
                    return b;
                   
                }
                if (countTries == 10)
                {
                    Console.WriteLine("Loss!\nPlay Again? (y/n)");
                    if (Console.ReadKey().KeyChar == 'n')
                    {
                        Environment.Exit(0);
                    }
                    return b;
                }
                
                Console.WriteLine("Fails: " + countTries + "/10");
                count = 0;
                Console.WriteLine(doldBokstav);
            }

        }

    }
}
