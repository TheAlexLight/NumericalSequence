using _7.NumericalSequence.Interfaces;
using System.Collections.Generic;

namespace _7.NumericalSequence.Logic
{
    internal class NumericSequence : ISequence
    {
        public NumericSequence(int number)
        {
            _number = number;
        }

        private readonly int _number;

        public int Number => _number;

        public IEnumerable<int> GetSequence()
        {
            for (int currentNumber = 0; currentNumber * currentNumber < _number; currentNumber++)
            {
                yield return currentNumber;
            }

            yield break;
        }
    }
}
