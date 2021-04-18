using System;

using _7.NumericalSequence.Controllers;
using _7.NumericalSequence.Logic.Abstract;
using _7.NumericalSequence.Logic.Builders;
using TasksLibrary;

namespace _7.NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            FullFactory allFactories = new FullFactory(new ConsoleTasksLibBuilder(), new ValidatorBuilder(), new NumericSequenceBuilder());

            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException();
                }

                Controller SequenceController = new NumericSequenceController(allFactories.TasksLibFactory, allFactories.SequenceFactory,
                        allFactories.ValidatorFactory);

                SequenceController.Initialize(args[0]);
            }
            catch (Exception)
            {
                IOutsidePrinter printer = allFactories.TasksLibFactory.CreatePrinter();
                printer.ShowInstruction();
            }

        }
    }
}
