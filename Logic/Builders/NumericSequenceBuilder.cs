using System.Collections.Generic;

using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.View;
using TasksLibrary;

namespace _7.NumericalSequence.Logic.Builders
{
    class NumericSequenceBuilder : ISequenceFactory
    {
        public ISequence CreateSequence(int number)
        {
            return new NumericSequence(number);
        }

        public ISequenceViewer CreateSequenceViewer(IEnumerable<int> receivedSequence, IOutsidePrinter printer)
        {
            return new NumericSequenceViewer(receivedSequence, printer);
        }
    }
}
