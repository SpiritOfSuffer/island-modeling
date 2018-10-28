using System;
using System.Collections.Generic;
using System.Text;


namespace Core
{
    public class BasicFunctionsHelper
    {
        /// <summary>
        /// The first function, which describes the island. 
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <returns>The Y-coordinate(value of a function)</returns>
        public double Y(double x) => Math.Exp(0.5 * x) - 5 * x + 14;

        /// <summary>
        /// The second function, which describes the island. 
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <returns>The Z-coordinate(value of a function) </returns>
        public double Z(double x) => 10 * (Convert.ToInt16((Math.Log(x + 1))) ^ 2) * Math.Sin(0.5 * x) + 15;

        /// <summary>
        /// Expression y(x) = z(x) (or y(x) - z(x)). Need to find the point, in which these functions intersect(the right border of the island).
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <returns>The C-coordinate(value of a function)</returns>
        public double C(double x) => Y(x) - Z(x);

        /// <summary>
        /// The derivative of a function: f(x) = y(x) + z(x). Need for integrand function to find the length of a coastline.
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <returns>The value of a df(x)/dx</returns>
        public double Derivative(double x) => 0.5 * Math.Exp(0.5 * x) + 5 * (Convert.ToInt16(Math.Log(x + 1)) ^ 2) * (Math.Cos(0.5 * x)) + (20 * (Math.Log(x + 1)) * Math.Sin(0.5 * x)) / (x + 1) - 5;

        /// <summary>
        /// The integrand function, which describes the island's coastline. Need to find the length of it.
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <returns>The value of an integrand function</returns>
        public double Integrand(double x) => Math.Sqrt(1 + (Convert.ToInt16(Derivative(x)) ^ 2));

    }
}
