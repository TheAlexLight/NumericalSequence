using TasksLibrary;

namespace _7.NumericalSequence.Interfaces.Factory
{
    public interface ITasksLibFactory
    {
        IOutsidePrinter CreatePrinter();
        IConverter CreateConverter();
    }
}
