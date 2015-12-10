using System.Collections.Generic;

namespace TestLibrary
{
    public class Math
    {
        public double Sum(List<double> numberList)
        {
            double number = 0;
            foreach (var item in numberList)
            {
                number += item;
            }
            return number;
        }
    }
}
