using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Logica
{
    public static class ClaseEstatica
    {
        public static double Celsius { get; set; }
        public static double Fahrenheit { get; set; }

       
        public static double ConvertirAFahrenheit()
        {
            double CaF = Celsius * 2.12;

            return CaF;


        }

        public static double ConvertirACelsius()
        {
            double FaC = Fahrenheit * 2.12;

            return FaC;


        }


    }
}
