using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework07
{
    public class NumberStats
    { 
        public double Number { get; set; }

        public string NumberPosOrNegative()
        {
            if (Number < 0) 
            {
                return $"The number is negative.";
            }
            else if (Number > 0)
            {
                return $"The number is positive.";
            }
            else return $"Your number is 0.";
        }

        public string NumberOddOrEven()
        {
            if (Number % 2 == 0) 
            {
                return $"Your number is even.";
            }
            else return $"Your number is odd.";
        }

        public string DecimalOrInteger()
        {
            if (Number % 1 != 0)
            {
                return $"Your number is decimal.";
            }
            else return $"Your number is integer.";
        }
        public NumberStats(double number)
        {
            Number = number;
        }
        
        public NumberStats() { }

    }
}
