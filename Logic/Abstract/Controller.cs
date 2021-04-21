using _7.NumericalSequence.Controllers;
using _7.NumericalSequence.Interfaces.Factory;

namespace _7.NumericalSequence.Logic.Abstract
{
    public abstract class Controller
    {
        readonly protected FullFactory _allFactories;

        public Controller(FullFactory allFactories)
        {
            _allFactories = allFactories;
        }

        public abstract void Initialize(string number);
    }
}
