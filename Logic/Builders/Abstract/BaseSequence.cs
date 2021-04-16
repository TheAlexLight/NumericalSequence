using _7.NumericalSequence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Logic.Builders.Abstract
{
    public abstract class BaseSequence
    {
        public abstract ISequence CreateSequence(int number);
    }
}
