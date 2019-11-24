using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers.RomanNumbers
{
    public class RomanNumeral
    {
        public int Number { get; set; }
        public string RomanNumber { get; set; }

        public RomanNumeral(int number, string romanNumber)
        {
            Number = number;
            RomanNumber = romanNumber;
        }
    }
}
