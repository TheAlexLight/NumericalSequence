using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TasksLibrary;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Validation;
using _7.NumericalSequence.View;

namespace _7.NumericalSequence.Logic.Builders
{
    public class ConsoleTasksLibBuilder : ITasksLibFactory
    {
        public IConverter CreateConverter()
        {
            return new Converter();
        }

        public IOutsidePrinter CreatePrinter()
        {
            return new ConsolePrinter();
        }
    }
}
