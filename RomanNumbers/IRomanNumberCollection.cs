using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public interface IRomanNumberCollection
    {
        public string ConvertToRomanNumber(int number);
        public Dictionary<string, int> RomanNumbersToNumbers();

    }
}
