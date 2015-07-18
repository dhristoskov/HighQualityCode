using System;

namespace Abstraction
{
    /// <summary>
    /// Interface for classes capable of creating Figures
    /// </summary>
    internal interface IFigure
    {
        /// <summary>
        /// Calculate Figure perimeter
        /// </summary>
        /// <returns>floating - point value</returns>
        double CalculatePerimeter();

        /// <summary>
        /// Calculate Figure Surface
        /// </summary>
        /// <returns>floating - point value</returns>
        double CalculateSurface();
    }
}