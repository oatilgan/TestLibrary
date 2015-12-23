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
            double count = 1;
            foreach (var item in numberList)
                count *= item;

            return count;
        }
    }
}
