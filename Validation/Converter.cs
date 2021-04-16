using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksLibrary;

namespace _7.NumericalSequence.Validation
{
    internal class Converter : IConverter
    {
        readonly CultureInfo culture = (CultureInfo)CultureInfo.CurrentUICulture.Clone();

        public Converter()
        {
            culture.NumberFormat.CurrencyDecimalSeparator = ".";
        }

        public float ParseToFloat(string strToCheck)
        {
            float result = -1;

            if (float.TryParse(strToCheck, NumberStyles.Any, culture, out _))
            {
                result = float.Parse(strToCheck, NumberStyles.Any, culture);
            }

            return result;
        }

        public int TryParseToInt(string strToCheck)
        {
            int result = -1;

            if (Int32.TryParse(strToCheck, out _))
            {
                result = Int32.Parse(strToCheck);
            }

            return result;
        }
    }
}
