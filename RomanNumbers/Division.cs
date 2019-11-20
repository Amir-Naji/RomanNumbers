using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public class Division: IDivision
    {
        public List<int> GetAllNumbers(int number, int divisor)
        {
            if (number / divisor == 0)
                return new List<int>();

            List<int> allNumbers = GetAllNumbers(number, divisor * 10);

            number -= CalcCurrentValue(allNumbers);
            allNumbers.Add(CurrentNumber(number, divisor));

            return allNumbers;
        }

        private int CurrentNumber(int number, int divisor)
        {
            return (number / divisor) * divisor;
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
