﻿using System;
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
        public NumericSequenceController(ITasksLibFactory tasksLibFactory, ISequenceFactory sequenceFactory, IValidatorFactory validatorFactory)
                : base(tasksLibFactory, sequenceFactory, validatorFactory)
        {
        }

        public override void Initialize(string number)
        {
            IOutsidePrinter printer = _taskLibFactory.CreatePrinter();

            try
            {
                IConverter converter = _taskLibFactory.CreateConverter();
                IValidator validator = _validatorFactory.CreateValidator();

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

                ISequence sequence = _sequenceFactory.CreateSequence(convertedNumber);
                ISequenceViewer viewer = _sequenceFactory.CreateSequenceViewer(sequence.GetSequence(), printer);

                viewer.ShowSequence(convertedNumber);
            }
            catch (ArgumentException ex)
            {
                printer.WriteLine(string.Format(Constant.ERROR_OCCURED,ex.Message), (int)Color.Red);
                throw;
            }
        }
    }
}
