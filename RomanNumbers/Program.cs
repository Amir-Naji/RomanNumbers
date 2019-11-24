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

        private IRomanNumberCollection collections;
        private IDivision division;

        public void Factory()
        {
            collections = new RomanNumberCollection();
            division = new Division();
        }

        public string ConvertToRomanNumber(int number)
        {
            string result = "";
            foreach (var num in
                RemoveZeroInList(division.GetAllNumbers(number, 1)))
            {
                result += collections.ConvertToRomanNumber(num);
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
