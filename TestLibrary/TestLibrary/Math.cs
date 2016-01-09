using System.Collections.Generic;
using System.Linq;

namespace TestLibrary
{
    public class Math
    {
        /// <summary>
        /// Toplama Methodu
        /// </summary>
        /// <param name="numberList">double tipinde liste alır.</param>
        /// <returns>double tipinde değer döner.</returns>
        public double Sum(List<double> numberList)
        {
            return numberList.Sum();
        }

        /// <summary>
        /// Çarpma Methodu
        /// </summary>
        /// <param name="numberList">double tipinde liste alır.</param>
        /// <returns>double tipinde değer döner.</returns>
        public double Carp(List<double> numberList)
        {
            double count = 1;
            foreach (var item in numberList)
                count *= item;

            return count;
        }
    }
}
