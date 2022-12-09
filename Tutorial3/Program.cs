using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            double result;
            Console.WriteLine("First Number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Choose a for Adding, s for Subtracting, m for Multiply, d for Divide");
            string main = Console.ReadLine();
            Console.WriteLine(main);
            if(main == "a")
            {
                result = number1 + number2;
                Console.WriteLine("Result is {0}", result);
            }
            else if(main == "s")
            {
                result = number1 - number2;
                Console.WriteLine("Result is {0}",result);
            }
            else if (main == "m")
            {
                result = number1 * number2;
                Console.WriteLine("Result is {0}", result);
            }
            else if (main == "d")
            {
                result = number1 / number2;
                Console.WriteLine("Result is {0}", result);
            }
            else
            {
                Console.WriteLine("Please Above Character is inputting");
            }

;        }
    }
}
