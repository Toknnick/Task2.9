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
            int number = random.Next(minValueRandom, maxValueRandom);
            int amountNumbers = 0;
            int maxValueTNumber = 999;
            int minValueTNumber = 99;

            for (; number <= minValueTNumber; number += number) {}
            for (; number <= maxValueTNumber; number += number)
            {
                Console.WriteLine(number);
                amountNumbers++;
            }
        }
    }
}
