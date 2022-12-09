using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int count = 1;
            int starCount = 6;
            count = starCount - 1;
            for (int i = 1; i <= starCount; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            count = 1;
            for (int i = 1; i <= starCount - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }

                count++;
                for (int k = 1; k <= 2 * (starCount - i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
