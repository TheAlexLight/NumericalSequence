using _7.NumericalSequence.Interfaces.Factory;

namespace _7.NumericalSequence.Logic.Abstract
{
    public abstract class Controller
    {
        readonly protected ITasksLibFactory _taskLibFactory;
        readonly protected ISequenceFactory _sequenceFactory;
        readonly protected IValidatorFactory _validatorFactory;

        public Controller(ITasksLibFactory tasksLibFactory, ISequenceFactory sequenceFactory, IValidatorFactory validatorFactory)
        {
            _taskLibFactory = tasksLibFactory;
            _sequenceFactory = sequenceFactory;
            _validatorFactory = validatorFactory;
        }

        public abstract void Initialize(string number);
    }
}
