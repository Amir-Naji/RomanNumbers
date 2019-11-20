using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public class RomanNumberCollection: IRomanNumberCollection
    {
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

        public Dictionary<int, string> NumbersToRomanNumbers()
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
    }
}
