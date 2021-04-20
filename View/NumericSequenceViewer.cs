using System;
using System.Collections.Generic;
using System.Linq;
using _7.NumericalSequence.Enums;
using _7.NumericalSequence.Interfaces;
using TasksLibrary;

namespace _7.NumericalSequence.View
{
    class NumericSequenceViewer : ISequenceViewer
    {
        public NumericSequenceViewer(IEnumerable<int> receivedSequence, IOutsidePrinter printer, int maxValue)
        {
            _receivedSequence = receivedSequence;
            _printer = printer;
            _maxValue = maxValue;
        }

        readonly IEnumerable<int> _receivedSequence;
        readonly IOutsidePrinter _printer;
        readonly int _maxValue;

        public void ShowSequence()
        {
            int last = _receivedSequence.Last();

            _printer.WriteLine(string.Format(Constant.NUMERIC_SEQUENCE_RESULT,  _maxValue), (int)Color.Yellow);

            Console.ForegroundColor = ConsoleColor.White;

            foreach (var number in _receivedSequence)
            {
                if (!number.Equals(last))
                {

                    _printer.Write(string.Format("{0}, \t", number));
                }
                else
                {
                    _printer.WriteLine(string.Format("{0}\t", number));
                }
            }

            Console.ResetColor();
        }
    }
}
