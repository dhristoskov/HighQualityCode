using System;

namespace MultiplyMatrices
{
    internal class MultiplyMatrix
    {
        private static void Main(string[] args)
        {
            double[,] matrix = {{1, 3}, {5, 7}};
            double[,] secondMatrix = {{4, 2}, {1, 5}};

            double[,] resultMatrix = MultiplyMatrices (matrix, secondMatrix);
            PrintMatrix(resultMatrix);
        }

        /// <summary>
        /// Printing 2D array
        /// </summary>
        /// <param name="matrix"></param>
        private static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method that multiply two 2D arrays
        /// first col*second row
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns>double[,] resultMatrix</returns>
        private static double[,] MultiplyMatrices (double[,] matrix, double[,] secondMatrix)
        {
            if (matrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("2D arrays have different length!");
            }

            int elements = matrix.GetLength(1);
            double[,] resultMatrix = new double[matrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int a = 0; a <= resultMatrix.GetUpperBound(0); a++)
            {
                for (int b = 0; b <= resultMatrix.GetUpperBound(1); b++)
                {
                    for (int c = 0; c < elements; c++)
                    {
                        resultMatrix[a, b] += matrix[a, c]*secondMatrix[c, b];
                    }
                }
            }              
            return resultMatrix;
        }
    }
}