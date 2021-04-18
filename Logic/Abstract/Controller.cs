using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Logic.Builders.Abstract;

namespace _7.NumericalSequence.Logic.Abstract
{
    public abstract class Controller
    {
        readonly protected ITasksLibFactory _taskLibFactory;
        readonly protected BaseSequence _sequenceBuilder;
        readonly protected IValidatorFactory _validatorFactory;

        public Controller(ITasksLibFactory tasksLibFactory, BaseSequence sequenceBuilder, IValidatorFactory validatorFactory)
        {
            _taskLibFactory = tasksLibFactory;
            _sequenceBuilder = sequenceBuilder;
            _validatorFactory = validatorFactory;
        }

        public abstract void Initialize(string number);
    }
}
