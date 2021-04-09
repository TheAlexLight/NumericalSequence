using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Validation
{
    class Validator
    {
        public bool CheckIntOnPositive(int intToCheck, int maxValue)
        {
            return (intToCheck > 1 && intToCheck <= maxValue);
        }
    }
}
