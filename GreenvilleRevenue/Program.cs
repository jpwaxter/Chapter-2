using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many contestants entered last year? ");
            int contestantsLast = int.Parse(Console.ReadLine());

            Console.Write("How many contestants entered this year? ");
            int contestantsNow = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Contestants last year: " + contestantsLast);
            Console.WriteLine(" Contestants this year: " + contestantsNow);
            Console.WriteLine("-----------------------------");

            double rev = contestantsNow * 25;
            Console.WriteLine(" Revenue for this year: {0}", rev.ToString("C"));

            if (contestantsLast < contestantsNow)
            {
              Console.WriteLine(" This year has more contestants than last year. ");
            } 
            else if (contestantsLast > contestantsNow) 
            {
              Console.WriteLine(" This year has fewer contestants than last year. ");
            } 
            else
            {
              Console.WriteLine(" This year has the same number of contestants as last year. ");
            }
            Console.ReadKey();
        }
    }
}
