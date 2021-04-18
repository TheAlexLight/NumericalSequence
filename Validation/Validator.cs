using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Validation
{
    internal class Validator : IValidator
    {
        public bool CheckIntOnPositive(int intToCheck)
        {
            return (intToCheck > 1 && intToCheck < Constant.MAX_NUMBER_VALUE);
        }
    }
}
