using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class DateTimeUtility
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int year = int.Parse(Console.ReadLine());
            GetCenturyAndCheckLeapYear(year);
        }
        public static void GetCenturyAndCheckLeapYear(int year)
        {
            int retVal = 0;
            if (year < 1000)
            {
                retVal = -1;
                Console.WriteLine("Output : " + retVal);
            }
            else if (year > 1000)
            {
                int cent = year / 100;
                year %= 100;
                if (year > 0)
                {
                    cent = cent + 1;
                }

                if ((year % 400) == 0 || (year % 100) == 0 || (year % 4) == 0)
                {
                    retVal = 1;
                }
                else
                {
                    retVal = -1;
                }
                //Console.WriteLine("Output : " + $"{cent},{retVal}");
                Console.WriteLine("Output : {0},{1} " , cent,retVal);
            }
        }
    }
}
