using RomanNumbers.RomanNumbers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers.Enumerable
{
    public class RomanNumerals: IEnumerable
    {
        private List<RomanNumeral> romanNumerals = new List<RomanNumeral>();

        public RomanNumerals(List<RomanNumeral> romanNumerals)
        {
            this.romanNumerals = romanNumerals;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public RomanNumeralEnum GetEnumerator()
        {
            return new RomanNumeralEnum(romanNumerals);
        }
    }
}
