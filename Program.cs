using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _7.NumericalSequence.Controllers;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Logic;
using _7.NumericalSequence.Logic.Abstract;
using _7.NumericalSequence.Logic.Builders;
using TasksLibrary;

namespace _7.NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            ITasksLibFactory tasksLibFactory = new ConsoleTasksLibBuilder();

            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException();
                }

                Controller SequenceController = new NumericSequenceController(tasksLibFactory);

                SequenceController.Initialize(args[0]);
            }
            catch (Exception)
            {
                IOutsidePrinter printer = tasksLibFactory.CreatePrinter();
                printer.ShowInstruction();
            }

        }
    }
}
