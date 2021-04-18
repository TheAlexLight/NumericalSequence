using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Interfaces.Factory
{
    public interface ISequenceFactory
    {
        ISequence CreateSequence(int number);
        ISequenceViewer CreateSequenceViewer(IEnumerable<int> receivedSequence);
    }
}
