using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Logic;
using _7.NumericalSequence.Logic.Abstract;
using _7.NumericalSequence.Logic.Builders;
using _7.NumericalSequence.Logic.Builders.Abstract;
using _7.NumericalSequence.Validation;
using _7.NumericalSequence.View;
using TasksLibrary;

namespace _7.NumericalSequence.Controllers
{
    class NumericSequenceController : Controller
    {
        public NumericSequenceController(ITasksLibFactory tasksLibFactory) : base(tasksLibFactory)
        {
        }

        readonly BaseSequence _sequenceBuilder = new NumericSequenceBuilder();

        readonly Validator _validArgs = new Validator();

        public override void Initialize(string number)
        {
            IConverter converter = _taskLibFactory.CreateConverter();
            IOutsidePrinter printer = _taskLibFactory.CreatePrinter();

            int convertedNumber = converter.TryParseToInt(number);

            if (convertedNumber == -1)
            {
                printer.WriteLine(Constant.INT_WRONG_TYPE);
                printer.ShowInstruction();
                Environment.Exit(-1);
            }

            if (!_validArgs.CheckIntOnPositive(convertedNumber))
            {
                printer.WriteLine(Constant.WRONG_BOUNDARIES);
                printer.ShowInstruction();
                Environment.Exit(-1);
            }

            ISequence sequence = _sequenceBuilder.CreateSequence(convertedNumber);

            NumericSequenceViewer viewer = new NumericSequenceViewer(sequence.GetSeqence());

            viewer.ShowNumericSequence(convertedNumber);

        }
    }
}
