using RomanNumbers.Enumerable;
using RomanNumbers.RomanNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public class RomanNumberCollection : IRomanNumberCollection
    {
        private RomanNumeralEnum romanNumbers;
        private RomanNumeralEnum RomanNumbersExtraCases;

        public RomanNumberCollection()
        {
            AddRomanNumbers();
            AddCasesRomanNumbers();
        }

        public Dictionary<string, int> RomanNumbersToNumbers()
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

        public string ConvertToRomanNumber(int number)
        {
            if (romanNumbers.HasNumber(number))
                return romanNumbers.GetRomanNumber(number);
            if (RomanNumbersExtraCases.HasNumber(number))
                return RomanNumbersExtraCases.GetRomanNumber(number);
            return CalcOtherNumbers(number);
        }

        private void AddRomanNumbers()
        {
            romanNumbers = new RomanNumerals(
                new List<RomanNumeral>()
                {
                    new RomanNumeral(1, "I"),
                    new RomanNumeral(5, "V"),
                    new RomanNumeral(10, "X"),
                    new RomanNumeral(50, "L"),
                    new RomanNumeral(100, "C"),
                    new RomanNumeral(500, "D"),
                    new RomanNumeral(1000, "M")
                }).GetEnumerator();
        }

        private void AddCasesRomanNumbers()
        {
            RomanNumbersExtraCases = new RomanNumerals(
                new List<RomanNumeral>()
                {
                    new RomanNumeral(4, "IV"),
                    new RomanNumeral(9, "IX"),
                    new RomanNumeral(40, "XL"),
                    new RomanNumeral(90, "XC"),
                    new RomanNumeral(400, "CD"),
                    new RomanNumeral(900, "CM")
                }).GetEnumerator();
        }

        private string CalcOtherNumbers(int number)
        {
            romanNumbers.Reset();
            while(romanNumbers.MoveNext())
            {
                if (number < romanNumbers.Current.Number)
                {
                    return CreateExtraNumbers(romanNumbers.Perivous.Number, number);
                }
            }
            return string.Empty;
        }


        //Recursive is needed.
        private string CreateExtraNumbers(int number, int actualNumber)
        {
            var result = "";
            var currentNumber = number;
            while(currentNumber <= actualNumber)
            {
                currentNumber += number;
                result += romanNumbers.GetRomanNumber(number);
            }
            return result;
        }
    }
}
