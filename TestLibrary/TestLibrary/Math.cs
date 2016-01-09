using System.Collections.Generic;
using System.Linq;

namespace TestLibrary
{
    public class Math
    {
        public double Sum(List<double> numberList)
        {
            return numberList.Sum();
        }

        public double Carp(List<double> numberList)
        {
            double result = 1;
            foreach (var item in numberList)
                result *= item;
            
            return result;
        }
    }
}
