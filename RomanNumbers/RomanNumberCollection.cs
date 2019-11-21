using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public class RomanNumberCollection : IRomanNumberCollection
    {
        public RomanNumberCollection()
        {
            AddRomanNumbers();
            AddCasesRomanNumbers();
        }

        public Dictionary<int, string> ToRomanNumbers { get; set; } = new Dictionary<int, string>();

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

        private void AddRomanNumbers()
        {
            ToRomanNumbers.Add(1, "I");
            ToRomanNumbers.Add(5, "V");
            ToRomanNumbers.Add(10, "X");
            ToRomanNumbers.Add(50, "L");
            ToRomanNumbers.Add(100, "C");
            ToRomanNumbers.Add(500, "D");
            ToRomanNumbers.Add(1000, "M");
        }

        private void AddCasesRomanNumbers()
        {
            ToRomanNumbers.Add(4, "IV");
            ToRomanNumbers.Add(9, "IX");
            ToRomanNumbers.Add(40, "XL");
            ToRomanNumbers.Add(90, "XC");
            ToRomanNumbers.Add(400, "CD");
            ToRomanNumbers.Add(900, "CM");
        }
    }
}
