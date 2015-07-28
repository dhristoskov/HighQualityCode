using System;

namespace Matrix
{
    internal static class MatrixTraversUtil
    {
        //Patterns
        private static readonly int[] DirectionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static readonly int[] DirectionY = { 1, 0, -1, -1, -1, 0, 1, 1 };


        /// <summary>
        /// Generates and fill a matrix with numbers 
        /// </summary>
        /// <param name="size">The size of rows and cols</param>
        /// <returns>A matrix filled with numbers using specific pattern</returns>
        public static int[,] GenerateMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            Cell startingCell = FindEmptyCell(matrix);
            if (startingCell != null)
            {
                FillMatrix(matrix, startingCell);
            }

            return matrix;
        }

        /// <summary>
        /// Search for first empty cell in 
        /// 2D array
        /// </summary>
        /// <param name="matrix">2D array</param>
        /// <returns>null if empty Cell does not exist,
        /// or new Cell</returns>
        private static Cell FindEmptyCell(int[,] matrix)
        {
            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        var emptyCell = new Cell(row, col);
                        return emptyCell;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Check if cell is usable, if it is inside 
        /// the matrix and if its equale to zero
        /// </summary>
        /// <param name="matrix">2D array</param>
        /// <param name="cell">struct Cell </param>
        /// <returns>boolean value</returns>
        private static bool IsCellUsable(int[,] matrix, Cell cell)
        {
            bool isCellUsable = cell.X >= 0 && cell.X < matrix.GetLength(0) && cell.Y >= 0
                            && cell.Y < matrix.GetLength(1) && matrix[cell.X, cell.Y] == 0;

            return isCellUsable;
        }

        /// <summary>
        /// Check if next cell is usable
        /// </summary>
        /// <param name="matrix">2D array</param>
        /// <param name="cell">struct Cell</param>
        /// <param name="index">index of pattern array</param>
        /// <returns>boolean value</returns>
        private static bool IsNextCellUsable(int[,] matrix, Cell cell, int index)
        {
            var nextCell = new Cell()
            {
                X = cell.X + DirectionX[index],
                Y = cell.Y + DirectionY[index]
            };

            return IsCellUsable(matrix, nextCell);
        }

        /// <summary>
        /// Check if there is avaliable
        /// move, (empty cell)
        /// </summary>
        /// <param name="matrix">2D array</param>
        /// <param name="cell">struct Cell</param>
        /// <param name="index">index of pattern array</param>
        /// <returns>boolean value</returns>
        private static bool HasAvailableMove(int[,] matrix, Cell cell, int index)
        {
            foreach (var element in DirectionX)
            {
                index = (index + 1) % DirectionX.Length;

                if (IsNextCellUsable(matrix, cell, index))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Fill matrix with numbers
        /// operation
        /// </summary>
        /// <param name="matrix">2D array</param>
        /// <param name="startingCell">first empty cell</param>
        private static void FillMatrix(int[,] matrix, Cell startingCell)
        {
            var cell = startingCell;
            var index = 0;

            while (IsCellUsable(matrix, cell))
            {
                matrix[cell.X, cell.Y] = cell.Value;

                while (!IsNextCellUsable(matrix, cell, index) &&
                       HasAvailableMove(matrix, cell, index))
                {
                    index = (index + 1) % DirectionX.Length;
                }

                cell.X += DirectionX[index];
                cell.Y += DirectionY[index];
                cell.Value++;
            }

            // Calls FillMatrix recursively with next empty cell if exists
            var nextCell = FindEmptyCell(matrix);
            if (nextCell != null)
            {
                nextCell.Value = cell.Value;
                FillMatrix(matrix, nextCell);
            }
        }
    }
}
