using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Logic.Builders.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Logic.Builders
{
    class NumericSequenceBuilder : BaseSequence
    {
        public override ISequence CreateSequence(int number)
        {
            return new NumericSequence(number);
        }
    }
}
