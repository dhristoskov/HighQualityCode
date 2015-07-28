using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    internal class MatrixMain
    {
        /// <summary>
        /// Read a user input from a console
        /// </summary>
        /// <returns>integer number a matrixSize
        /// dimension of 2D array</returns>
        private static int ReadUserInput()
        {
            Console.WriteLine("Enter a positive number: ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException(nameof(input), "Input string can not be empty or null!");
            }

            int matrixSize;
            while (!int.TryParse(input, out matrixSize) || matrixSize < 0 || matrixSize > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            return matrixSize;
        }

        /// <summary>
        /// Print a 2D array
        /// </summary>
        /// <param name="matrix">2D integer array</param>
        private static void PrintMatrix(int [,] matrix)
        {
            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    Console.Write("|{0,3}|", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void Main(string[] args)
        {
            int matrixSize = ReadUserInput();
            var matrix = MatrixTraversUtil.GenerateMatrix(matrixSize);
            PrintMatrix(matrix);
        }
    }
}
