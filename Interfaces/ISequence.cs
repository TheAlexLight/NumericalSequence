using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumericalSequence.Interfaces
{
    public interface ISequence
    {
        IEnumerable<int> GetSequence();
    }
}
