using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AHBCLab10
{

    class Circle
    {
        public double Radius { get; set; }

        private double radius;

        /// <summary>
        /// Creates a circle with a given radius.
        /// </summary>
        /// <param name="radius">Radius given by the user</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Calculates the circumference of the circle
        /// </summary>
        /// <returns>The circumference of the circle</returns>
        private double CalculateCircumference()
        {
            return radius * 2 * Math.PI;
        }

        /// <summary>
        /// Formats the circle's circumference
        /// </summary>
        /// <returns>The circle's circumference to the nearest 2 decimal places</returns>
        public string CalculateFormattedCircumference()
        {
            var circumference = CalculateCircumference();
            return FormatNumber(circumference);
        }

        /// <summary>
        /// Calculates the area of the circle
        /// </summary>
        /// <returns>The area of the circle</returns>
        private double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Formats the circle's area
        /// </summary>
        /// <returns>The circle's area to the nearest 2 decimal places</returns>
        public string CalculateFormattedArea()
        {
            var area = CalculateArea();
            return FormatNumber(area);
        }


        /// <summary>
        /// Formats a given double
        /// </summary>
        /// <param name="x">Double to format</param>
        /// <returns>Double rounded to the nearest 2 decimal places and converted to a string</returns>
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }


    }
}
