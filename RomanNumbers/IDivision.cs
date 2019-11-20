using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public interface IDivision
    {
        public List<int> GetAllNumbers(int number, int divisor);
    }
}
