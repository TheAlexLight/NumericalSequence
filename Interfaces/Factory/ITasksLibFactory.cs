using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TasksLibrary;

namespace _7.NumericalSequence.Interfaces.Factory
{
    public interface ITasksLibFactory
    {
        IOutsidePrinter CreatePrinter();
        IConverter CreateConverter();
    }
}
