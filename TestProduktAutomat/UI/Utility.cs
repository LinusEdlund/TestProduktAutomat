using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduktAutomat.Domain.Abstrakt;
using TestProduktAutomat.Domain.Entities;

namespace TestProduktAutomat.UI
{
    public class Utility
    {
       
        
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\nPress enter to continue...\n");
            Console.ReadLine();
        }


        
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine() ?? string.Empty;
        }


        //byter färg på texten
        public static void PrintMessage(string msg, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
            }

            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }


        //kommer ... animation som jag välja hur lång tid jag vill ha det
        public static void PrintDoAnimation(int timer = 10)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            
        }


        //Luis lärde mig det här. Gör så att jag kan få min välkom sak i mitten ovs vilken storlek du har på ditt fönster
        //och jag kan byta täcken om jag vill
        public static void PrintCenter(string text, int width)
        {
            var hf =  (width + text.Length) / 2;
            var fyext = text.PadLeft(hf, '-').PadRight(width, '-');
            Console.WriteLine(fyext);
        }

       


    }
}
