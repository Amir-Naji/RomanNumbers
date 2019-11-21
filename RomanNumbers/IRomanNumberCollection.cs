using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public interface IRomanNumberCollection
    {
        public Dictionary<int, string> ToRomanNumbers { get; set; }
        public Dictionary<string, int> RomanNumbersToNumbers();

    }
}
