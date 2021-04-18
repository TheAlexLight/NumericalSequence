using _7.NumericalSequence.Interfaces;
using _7.NumericalSequence.Interfaces.Factory;
using _7.NumericalSequence.Validation;

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
