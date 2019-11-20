using System;
using System.Collections.Generic;

namespace RomanNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public List<int> GetAllNumbers(int number, int divisionValue)
        {
            if (number / divisionValue == 0)
                return new List<int>();

            List<int> allNumbers = GetAllNumbers(number, divisionValue * 10);

            number -= CalcCurrentValue(allNumbers);
            allNumbers.Add(CurrentNumber(number, divisionValue));

            return allNumbers;
        }

        private int CurrentNumber(int number, int divisoin)
        {
            return (number / divisoin) * divisoin;
        }

        private int CalcCurrentValue(List<int> numbers)
        {
            var result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
