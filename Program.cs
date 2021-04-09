using _7.NumericalSequence.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericSequence sequence = new NumericSequence(10);

            var fullNumericalSequence = sequence.GetSeqence();

            foreach (var number in fullNumericalSequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
