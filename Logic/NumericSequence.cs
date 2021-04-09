using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Logic
{
    class NumericSequence
    {
        public NumericSequence(int number)
        {
            _number = number;
        }

        private readonly int _number;
        private int _currentNumber = 1;

        public IEnumerable<int> GetSeqence()
        {
            while (_currentNumber * _currentNumber < _number)
            {
                yield return _currentNumber;

                _currentNumber++;
            }

            yield break;
        }
    }
}
