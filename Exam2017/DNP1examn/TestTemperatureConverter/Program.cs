using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter;


namespace TestTemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            //Console.WriteLine(converter.CtoF(20));
            converter.CtoF(20);

            double[] Temperatures = { 60.0, 68.4, 72.2, 80.1, 20.8, 12.2 };
            for ( int i = 0; i< Temperatures.Length; i++ )
            {
                //Console.WriteLine(converter.CtoF(i));
                converter.CtoF(i);
            }
        }
    }
}
