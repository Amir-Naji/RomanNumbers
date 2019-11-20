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

        public string ConvertToRomanNumber(List<int> numbers)
        {
            string result = "";
            numbers = RemoveZeroInList(numbers);
            foreach (var number in numbers)
            {
                result += NumbersToRomanNumbers()[number];
            }
            return result;
        }

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

        private List<int> RemoveZeroInList(List<int> numbers)
        {
            while (numbers.Remove(0)) { }
            return numbers;
        }

        private Dictionary<string, int> RomanNumbersToNumbers()
        {
            return new Dictionary<string, int>()
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 }
            };
        }

        private Dictionary<int, string> NumbersToRomanNumbers()
        {
            return new Dictionary<int, string>()
            {
                { 1, "I" },
                { 5 , "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" },
                { 500, "D" },
                { 1000, "M" }
            };
        }

        public enum RomanNumber
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
    }
}
