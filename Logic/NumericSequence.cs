using _7.NumericalSequence.Interfaces;
using System.Collections.Generic;

namespace _7.NumericalSequence.Logic
{
    internal class NumericSequence : ISequence
    {
        public IEnumerable<int> GetSequence(int number)
        {
            for (int currentNumber = 1; currentNumber * currentNumber < number; currentNumber++)
            {
                yield return currentNumber;
            }

            yield break;
        }
    }
}
