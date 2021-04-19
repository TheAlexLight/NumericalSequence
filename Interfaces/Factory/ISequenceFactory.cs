using System.Collections.Generic;
using TasksLibrary;

namespace _7.NumericalSequence.Interfaces.Factory
{
    public interface ISequenceFactory
    {
        ISequence CreateSequence(int number);
        ISequenceViewer CreateSequenceViewer(IEnumerable<int> receivedSequence, IOutsidePrinter printer);
    }
}
