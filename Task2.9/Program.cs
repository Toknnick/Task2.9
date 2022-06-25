using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValueRandom = 28;
            int minValueRandom = 1;
            int numberFromRamdom = random.Next(minValueRandom, maxValueRandom);
            int countNumbers = 0;
            int maxValueTNumber = 999;
            int minValueTNumber = 99;
            int number = numberFromRamdom;

            while(number <= minValueTNumber)
            {
                number += numberFromRamdom;
            }
            
            for (; number <= maxValueTNumber; number += numberFromRamdom)
            {
                countNumbers++;
            }
            Console.WriteLine(countNumbers);
        }
    }
}
