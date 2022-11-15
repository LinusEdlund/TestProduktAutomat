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


        public static void PrintDoAnimation(int timer = 10)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            
        }


        public static void PrintCenter(string text, int width)
        {
            var hf =  (width + text.Length) / 2;
            var fyext = text.PadLeft(hf, '-').PadRight(width, '-');
            Console.WriteLine(fyext);
        }

        //fråga lärare om det går
        //public static void PrintOutList(List<var> name)
        // {
        //     int i = 1;
        //     foreach (var item in name)
        //     {
        //         Console.WriteLine($"{i}. " + item.Display);
        //         i++;

        //     }
        // }


    }
}
