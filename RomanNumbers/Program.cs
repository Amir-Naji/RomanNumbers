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

        IRomanNumberCollection collections;
        IDivision division;

        public void Factory()
        {
            collections = new RomanNumberCollection();
            division = new Division();
        }

        public string ConvertToRomanNumber(int number)
        {
            string result = "";
            var numbers = RemoveZeroInList(division.GetAllNumbers(number, 1));
            foreach (var num in numbers)
            {
                result += collections.ToRomanNumbers[num];
            }
            return result;
        }

        private List<int> RemoveZeroInList(List<int> numbers)
        {
            while (numbers.Remove(0)) { }
            return numbers;
        }
    }
}
