using System.Collections.Generic;

namespace _7.NumericalSequence.Interfaces.Factory
{
    public interface ISequenceFactory
    {
        ISequence CreateSequence(int number);
        ISequenceViewer CreateSequenceViewer(IEnumerable<int> receivedSequence);
    }
}
