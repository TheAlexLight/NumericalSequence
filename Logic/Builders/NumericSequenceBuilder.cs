using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Logic.Builders
{
    class NumericSequenceBuilder : ISequenceFactory
    {
        public ISequence CreateSequence(int number)
        {
            return new NumericSequence(number);
        }

        public ISequenceViewer CreateSequenceViewer(IEnumerable<int> receivedSequence)
        {
            return new NumericSequenceViewer(receivedSequence);
        }
    }
}
