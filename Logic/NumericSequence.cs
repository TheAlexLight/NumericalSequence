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

        public int Number => _number;

        public IEnumerable<int> GetSeqence()
        {
            int _currentNumber = 1;

            while (_currentNumber * _currentNumber < _number)
            {
                yield return _currentNumber;

                _currentNumber++;
            }

            yield break;
        }
    }
}
