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
        public NumericSequenceViewer(NumericSequence sequence)
        {
            _sequence = sequence;
        }

        readonly NumericSequence _sequence;

        public void ShowNumericSequence()
        {
            IEnumerable<int> _receivedSequence = _sequence.GetSeqence();

            int last = _receivedSequence.Last();

            Console.WriteLine(string.Format(Constant.NUMERIC_SEQUENCE_RESULT, _sequence.Number));

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
