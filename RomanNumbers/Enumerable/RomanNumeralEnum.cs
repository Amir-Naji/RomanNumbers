using RomanNumbers.RomanNumbers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumbers.Enumerable
{
    public class RomanNumeralEnum : IEnumerator
    {
        List<RomanNumeral> romanNumerals;

        private int position = -1;

        public RomanNumeralEnum(List<RomanNumeral> list)
        {
            romanNumerals = list;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public RomanNumeral Current
        {
            get
            {
                try
                {
                    return romanNumerals[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public RomanNumeral Perivous
        {
            get
            {
                try
                {
                    return romanNumerals[position - 1];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < romanNumerals.Count;
        }

        public bool MovePrevious()
        {
            position--;
            return position > -1;
        }

        public void Reset()
        {
            position = -1;
        }

        public bool HasNumber(int number)
        {
            return romanNumerals.Count(x => x.Number == number) > 0;
        }

        public string GetRomanNumber(int number)
        {
            return romanNumerals.FirstOrDefault(x => x.Number == number)?.RomanNumber;
        }
    }
}
