using _7.NumericalSequence.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Logic
{
    class NumericSequence : ISequence
    {
        public NumericSequence(int number)
        {
            _number = number;
        }

        private readonly int _number;

        public int Number => _number;

        public IEnumerable<int> GetSeqence()
        {
            for (int currentNumber = 0; currentNumber * currentNumber < _number; currentNumber++)
            {
                yield return currentNumber;
            }

            yield break;
        }
    }
}
