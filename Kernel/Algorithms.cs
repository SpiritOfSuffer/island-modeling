using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public class Algorithms
    {
        /// <summary>
        /// The source function f(x). We transfer it into Bisection() arguments with the delegate
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <returns>The value of a function f(x)</returns>
        public delegate double Function(double x);

        /// <summary>
        /// Function to find the root of the equation with Bisection method
        /// </summary>
        /// <param name="F">The source function(equatuin): f(x)</param>
        /// <param name="x0">Left border of the segment, where we will search the root</param>
        /// <param name="x1">Right border of the segment, where we will search the root</param>
        /// <param name="e">Accuracy</param>
        /// <returns>The value of the equation's root</returns>
        public static double Bisection(Function F, double x0, double x1, double e)
        {
            double x, f0, fm, f1;

            f0 = F(x0);
            f1 = F(x1);

            while (Math.Abs(x1 - x0) > e)
            {
                x = (x0 + x1) / 2;
                fm = F(x);

                if (fm == 0) return x;

                if (fm * f1 < 0)
                {
                    x0 = x;
                    f0 = fm;
                }
                else
                {
                    x1 = x;
                    f1 = fm;
                }
            }

            x = (x0 + x1) / 2;
            fm = F(x);

            return x;
        }
    }
}
