using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KyhLooparDemo
{
    internal class App
    {
        public void Run()
        {
            int tal1 = Convert.ToInt32( Console.ReadLine() );
            int tal2 = Convert.ToInt32( Console.ReadLine() );

            // 0 10 
            // 10 4 - 









            //Skapa ett program som skriver ut talen 0-10 på skärmen.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int counter3 = 0;
            while (counter3 <= 10)
            {
                Console.WriteLine(counter3);
                counter3++;
            }


            string namnet = "Stefan";
            char letter = 'A';

            foreach (char c in namnet)
            {
                Console.WriteLine(c);
            }


            while (true)
            {
                Console.WriteLine("1. Starta spelet");
                Console.WriteLine("2. Kolla highscore");
                Console.WriteLine("3. Avsluta");
                Console.Write("Vad vill du göra:");
                string sel = Console.ReadLine();
                if (sel == "1")
                {
                    Console.WriteLine("Spelet startar");
                    Console.WriteLine("...och slutar");
                }
                else if (sel == "2")
                {
                    Console.WriteLine("Highscore visas");
                    Console.WriteLine("klart");
                }
                else if (sel == "3")
                {
                    break;
                }
            } 


            //int age = 12;
            //if (age > 10)
            //{
            //    Console.WriteLine("Hej");
            //    Console.WriteLine("du är mer än 10");
            //}
            // age++ = +1
            // age-- = -1
            // age = age + 10
            // age += 10
            // age -= 10
            int age = 12; 
            age -= 10;
            // 22


            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine("Jag heter Stefan");
                Console.WriteLine("Hej");
                counter++; // counter = counter + 1
            }
            //      1. denna körs
            for (int counter2 = 0; counter2 < 5; counter2=counter2+ 1)
            {
                Console.WriteLine("Jag heter Stefan");
                Console.WriteLine("Hej");
            }
            

            //Skriv ut alla heltal mellan 2022 och 1972 i bakvänd ordning
            for (int year = 2022; year >= 1972; year--)
            {
                Console.WriteLine(year);
            }
            for (int year = 1972; year <= 2022; year++)
            {
                Console.WriteLine(year);
            }


            Console.WriteLine("Slut");
        }
    }
}
