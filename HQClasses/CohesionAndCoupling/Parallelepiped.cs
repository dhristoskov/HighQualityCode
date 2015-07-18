using System;
using CohesionAndCoupling.Utils;

namespace CohesionAndCoupling
{
    class Parallelepiped
    {
        private double _width;
        private double _height;
        private double _depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        #region Properties

        public double Width
        {
            get { return this._width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Parallelepiped Width can not be negative number or zaro!");
                }
                this._width = value;
            }
        }

        public double Height
        {
            get { return this._height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Parallelepiped Height can not be negative number or zaro!");
                }
                this._height = value;
            }
        }

        public double Depth
        {
            get { return this._depth; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Parallelepiped Depth can not be negative number or zaro!");
                }
                this._depth = value;
            }
        }

        #endregion
        #region Methods

        /// <summary>
        /// Calculate Parallelepiped volume
        /// </summary>
        /// <returns>floating - point value</returns>
        public double CalculateVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        /// <summary>
        /// Calculate diagonal X,Y,Z
        /// </summary>
        /// <returns>floating - point value</returns>
        public double CalculateDiagonalXyz()
        {
            double distance = PolygonUtil.CalculateDistanceIn3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        /// <summary>
        /// Calculate diagona X,Y
        /// </summary>
        /// <returns>floating - point value</returns>
        public double CalculateDiagonalXy()
        {
            double distance = PolygonUtil.CalculateDistanceIn2D(0, 0, Width, Height);
            return distance;
        }

        /// <summary>
        /// Calculate diagonal X,Z
        /// </summary>
        /// <returns>floating - point value</returns>
        public double CalculateDiagonalXz()
        {
            double distance = PolygonUtil.CalculateDistanceIn2D(0, 0, Width, Depth);
            return distance;
        }

        /// <summary>
        /// Calculate diagonal Y,Z
        /// </summary>
        /// <returns>floating - point value</returns>
        public double CalculateDiagonalYz()
        {
            double distance = PolygonUtil.CalculateDistanceIn2D(0, 0, Height, Depth);
            return distance;
        }

        #endregion
    }
}
