using _7.NumericalSequence.Interfaces.Factory;

namespace _7.NumericalSequence.Controllers
{
    class FullFactory
    {
        public FullFactory(ITasksLibFactory tasksLibFactory, IValidatorFactory validatorFactory, ISequenceFactory sequenceFactory)
        {
            _tasksLibFactory = tasksLibFactory;
            _validatorFactory = validatorFactory;
            _sequenceFactory = sequenceFactory;
        }

        readonly ISequenceFactory _sequenceFactory;
        readonly IValidatorFactory _validatorFactory;
        readonly ITasksLibFactory _tasksLibFactory;

        public ISequenceFactory SequenceFactory => _sequenceFactory;
        public IValidatorFactory ValidatorFactory => _validatorFactory;
        public ITasksLibFactory TasksLibFactory => _tasksLibFactory;
    }
}
