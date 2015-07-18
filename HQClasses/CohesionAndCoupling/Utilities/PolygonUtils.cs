using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Utilities
{
    /// <summary>
    /// Class that holds Distance calculation
    /// in 2D and 3D coordinate system
    /// </summary>
    static class PolygonUtils
    {
        /// <summary>
        /// Calculate distance by given coordinates x,y
        /// for points A and B
        /// </summary>
        /// <param name="x1">X coordiante  - point A</param>
        /// <param name="y1">Y coordiante  - point A</param>
        /// <param name="x2">X coordiante  - point B</param>
        /// <param name="y2">Y coordiante  - point B</param>
        /// <returns>floating - point value of distance 
        /// between two points </returns>
        public static double CalculateDistanceIn2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Calculate distance by given coordinates x,y,z 
        /// in 3D coorinate system for points A and B
        /// </summary>
        /// <param name="x1">X coordiante  - point A</param>
        /// <param name="y1">Y coordiante  - point A</param>
        /// <param name="z1">Z coordiante  - point A</param>
        /// <param name="x2">X coordiante  - point B</param>
        /// <param name="y2">Y coordiante  - point B</param>
        /// <param name="z2">Z coordiante  - point B</param>
        /// <returns>floating - point value of distance
        /// between two points</returns>
        public static double CalculateDistanceIn3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }
    }
}
