using System;
using _7.NumericalSequence.Enums;
using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Logic.Abstract;
using _7.NumericalSequence.View;
using TasksLibrary;

namespace _7.NumericalSequence.Controllers
{
    class NumericSequenceController : Controller
    {
        public NumericSequenceController(FullFactory allFactories)
                : base(allFactories)
        {
        }

        public override void Initialize(string number)
        {
            IOutsidePrinter printer = _allFactories.TasksLibFactory.CreatePrinter();

            try
            {
                IConverter converter = _allFactories.TasksLibFactory.CreateConverter();
                IValidator validator = _allFactories.ValidatorFactory.CreateValidator();

                int convertedNumber = converter.TryParseToInt(number);

                if (convertedNumber == -1)
                {
                    printer.WriteLine(Constant.INT_WRONG_TYPE, (int)Color.Red);
                    printer.ShowInstruction();
                    Environment.Exit(-1);
                }

                if (!validator.CheckIntOnPositive(convertedNumber))
                {
                    printer.WriteLine(Constant.WRONG_BOUNDARIES, (int)Color.Red);
                    printer.ShowInstruction();
                    Environment.Exit(-1);
                }

                ISequence sequence = _allFactories.SequenceFactory.CreateSequence();
                ISequenceViewer viewer = _allFactories.SequenceFactory.CreateSequenceViewer(sequence.GetSequence(convertedNumber), printer, convertedNumber);

                viewer.ShowSequence();
            }
            catch (ArgumentException ex)
            {
                printer.WriteLine(string.Format(Constant.ERROR_OCCURED,ex.Message), (int)Color.Red);
                throw;
            }
        }
    }
}
