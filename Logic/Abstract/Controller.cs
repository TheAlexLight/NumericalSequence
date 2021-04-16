using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _7.NumericalSequence.Interfaces.Factory;

namespace _7.NumericalSequence.Logic.Abstract
{
    public abstract class Controller
    {
        readonly protected ITasksLibFactory _taskLibFactory;

        public Controller(ITasksLibFactory tasksLibFactory)
        {
            _taskLibFactory = tasksLibFactory;
        }

        public abstract void Initialize(string number);
    }
}
