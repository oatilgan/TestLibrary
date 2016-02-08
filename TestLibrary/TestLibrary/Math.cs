using System.Collections.Generic;
using System.Linq;

namespace TestLibrary
{
    public class Math
    {
        /// <summary>
        ///     feature test 3
        /// </summary>
        /// <param name="numberList"></param>
        /// <returns></returns>
        public double ToplaByList(List<double> numberList)
        {
            return numberList.Sum();
        }

        public double Carp(List<double> numberList)
        {
            //double result = 1;
            //foreach (var item in numberList)
            //    result *= item;
            //return result;
            //return numberList.Aggregate<double, double>(1, (current, item) => current * item);

            return numberList.Aggregate<double, double>(1, (a, b) => a * b);
        }
    }
}
