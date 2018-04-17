using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Confirmation(string message)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Warning(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Main(String[] args)
        {
            int x = 0;
            if ((args.Length == 1) &&
                (Int32.TryParse(args[0], out x) == true) &&
                ((x >= 1) && (x <= 9)))
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine("Beep number {0}.", i);
                    Console.Beep();
                }
            }
            else
                Console.WriteLine("Usage: Enter the number of times (between 1 and 9) to beep.");
        }
    }
}
