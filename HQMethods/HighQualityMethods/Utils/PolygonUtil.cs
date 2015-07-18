using System;

namespace HighQualityMethods.Utils
{
    static class PolygonUtil
    {
        /// <summary>
        /// Calculate distance between
        /// two points A(x,y) and B(x,y)
        /// </summary>
        /// <param name="x1">x coordinate of A point</param>
        /// <param name="y1">y coordinate of A point</param>
        /// <param name="x2">x coordinate of B point</param>
        /// <param name="y2">y coordinate of B point</param>
        /// <returns>point distance</returns>
        public static double CalculatePointsDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
            return distance;
        }

        /// <summary>
        /// Compare y1 and y2 coordinate
        /// of point A and B if they are equale
        /// points A and B are horizontal
        /// </summary>
        /// <param name="y1">y coordinate of point A</param>
        /// <param name="y2">y coordinate of point B</param>
        /// <returns>boolean value</returns>
        public static bool ArePointsHorizontal(double y1, double y2)
        {
            bool arePointsHorizontal = Math.Abs(y1 - y2) < Double.Epsilon;
            return arePointsHorizontal;
        }

        /// <summary>
        /// Compare x1 and x2 coordinate
        /// of point A and B if they are equale
        /// points A and B are vertical
        /// </summary>
        /// <param name="x1">y coordinate of point A</param>
        /// <param name="x2">y coordinate of point B</param>
        /// <returns>boolean value</returns>
        public static bool ArePointsVertical(double x1, double x2)
        {
            bool arePointsVertical = Math.Abs(x1 - x2) < Double.Epsilon;
            return arePointsVertical;
        }

        /// <summary>
        /// Calculate the are of triangle
        /// by give 3 sides A,B,C
        /// </summary>
        /// <param name="a">side A of triangle</param>
        /// <param name="b">side B of triangle</param>
        /// <param name="c">side C of triangle</param>
        /// <returns>triangle area</returns>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive!");
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentOutOfRangeException("Can not form a triangle, incorrect side sizes!");
            }

            double s = (a + b + c)/2;
            double area = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
            return area;
        }
    }
}
