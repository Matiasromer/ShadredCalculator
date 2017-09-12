using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
    public class BasicMath
    {
        //public double A { get; set; }
        //public double B { get; set; }


        /// <summary>
        /// Metode for at pludse.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Plus(double a, double b)
        {
            double Sum;
            Sum = a + b;
            return Sum;
        }

        /// <summary>
        /// Metode for at minus.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Minus(double a, double b)
        {
            double Sum;
            Sum = a - b;
            return Sum;
        }

        /// <summary>
        /// Metode for at gange.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Gange(double a, double b)
        {
            double Sum;
            Sum = a * b;
            return Sum;
        }

        /// <summary>
        /// Metode for at dividere.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Divider(double a, double b)
        {
            double Sum;
            Sum = a / b;
            return Sum;
        }

        /// <summary>
        /// Metode for at sætte et tal i anden (x^2).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double iAnden(double a)
        {
            double Sum;
            Sum = a * a;
            return Sum;
        }
    }
}