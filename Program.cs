using _7.NumericalSequence.Controllers;
using _7.NumericalSequence.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException();
                }

                NumericSequenceController controller = new NumericSequenceController();

                controller.StartExecution(args[0]);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
