using _7.NumericalSequence.Interfaces.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Controllers
{
    class FullFactory
    {
        public FullFactory(ISequenceFactory sequenceFactory, IValidatorFactory validatorFactory, ITasksLibFactory tasksLibFactory)
        {
            _sequenceFactory = sequenceFactory;
            _validatorFactory = validatorFactory;
            _tasksLibFactory = tasksLibFactory;
        }

        readonly IOutsidePrinterFactory _printerFactory;
        readonly IValidatorFactory _validatorFactory;
        readonly IParcerFactory _tasksLibFactory;

        public IOutsidePrinterFactory PrinterFactory => _printerFactory;
        public IValidatorFactory ValidatorFactory => _validatorFactory;
        public IParcerFactory ParcerFactory => _tasksLibFactory;
    }
}
