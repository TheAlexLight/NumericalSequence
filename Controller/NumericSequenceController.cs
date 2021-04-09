using _7.NumericalSequence.Logic;
using _7.NumericalSequence.Validation;
using _7.NumericalSequence.View;
using ConsoleTaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Controller
{
    class NumericSequenceController
    {
        readonly Validator _validArgs = new Validator();
        readonly Converter _convertArgs = new Converter();
        readonly ConsolePrinter _printer = new ConsolePrinter();

        public void StartExecution(string number)
        {
            int _convertedNumber = _convertArgs.TryParseToInt(number);

            if (_convertedNumber == -1)
            {
                _printer.WriteLine(Constant.INT_WRONG_TYPE);
                _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT);
                Environment.Exit(-1);
            }

            if (!_validArgs.CheckIntOnPositive(_convertedNumber, Constant.MAX_NUMBER_VALUE))
            {
                _printer.WriteLine(Constant.WRONG_BOUNDARIES);
                _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT);
                Environment.Exit(-1);
            }

            NumericSequence sequence = new NumericSequence(_convertedNumber);

            NumericSequenceViewer viewer = new NumericSequenceViewer(sequence);

            viewer.ShowNumericSequence();

        }
    }
}
