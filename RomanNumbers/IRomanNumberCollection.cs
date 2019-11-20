using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public interface IRomanNumberCollection
    {
        public Dictionary<string, int> RomanNumbersToNumbers();

        public Dictionary<int, string> NumbersToRomanNumbers();
    }
}
