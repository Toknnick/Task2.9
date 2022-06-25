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
            int maxValue = 28;
            int minValue = 1;
            int number = random.Next(minValue, maxValue);
            int minValueThreeDigitNumber = 99;
            int maxValueThreeDigitNumber = 999;
            List<int> amountOfNumber = new List<int>();

            for (; number <= minValueThreeDigitNumber; number += number)
            {
                for (; number < maxValueThreeDigitNumber; number += number)
                {
                    amountOfNumber.Add(number);
                }
            }
        }
    }
}
