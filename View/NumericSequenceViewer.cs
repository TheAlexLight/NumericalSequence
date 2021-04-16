using _7.NumericalSequence.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.View
{
    class NumericSequenceViewer
    {
        public NumericSequenceViewer(IEnumerable<int> receivedSequence)
        {
            _receivedSequence = receivedSequence;
        }

        readonly IEnumerable<int> _receivedSequence;

        public void ShowNumericSequence(int startNumber)
        {
            int last = _receivedSequence.Last();

            Console.WriteLine(string.Format(Constant.NUMERIC_SEQUENCE_RESULT, startNumber));

            foreach (var number in _receivedSequence)
            {
                if (!number.Equals(last))
                {
                    Console.Write(string.Format("{0}, \t", number));
                }
                else
                {
                    Console.WriteLine(string.Format("{0}\t", number));
                }
            }
        }
    }
}
