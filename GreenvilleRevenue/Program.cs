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

            // Revenue / contestant comparison here
        }
    }
}
