using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Logic.Builders
{
    class ValidatorBuilder : IValidatorFactory
    {
        public IValidator CreateValidator()
        {
            return new Validator();
        }
    }
}
