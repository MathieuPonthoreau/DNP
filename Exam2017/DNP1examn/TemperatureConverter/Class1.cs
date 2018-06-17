using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Converter
    {
        public double CtoF (double temp)
        {
            return temp * 9 / 5 + 32;
        }
        public double FtoC (double temp)
        {
            return (temp-32)*5/9;
        }
    }
}
