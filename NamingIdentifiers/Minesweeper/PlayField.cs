using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class PlayField
    {
        private const int PlayFieldRows = 5;
        private const int PlayFieldCols = 10;
      
        public PlayField()
        {
            this.Field = new char[PlayFieldRows, PlayFieldCols];
            this.BombField = new char[PlayFieldRows, PlayFieldCols];
        }

        public char[,] Field { get; set; }
        public char[,] BombField { get; set; }


        /// <summary>
        /// Fill the matrix with "?"
        /// </summary>
        /// <returns></returns>
        public char[,] CreatePlayField()
        {
            for (int i = 0; i < PlayFieldRows; i++)
            {
                for (int j = 0; j < PlayFieldCols; j++)
                {
                    Field[i, j] = '?';
                }
            }
            return Field;
        }

        /// <summary>
        /// Set random bombs 
        /// in the field
        /// </summary>
        /// <returns></returns>
        public char[,] SetBombInPlayField()
        {
            List<int> bombList = new List<int>();

            for (int i = 0; i < BombField.GetLength(0); i++)
            {
                for (int j = 0; j < BombField.GetLength(1); j++)
                {
                    BombField[i, j] = '-';
                }
            }
            while (bombList.Count < 15)
            {
                Random random = new Random();
                int fieldNumber = random.Next(50);
                if (!bombList.Contains(fieldNumber))
                {
                    bombList.Add(fieldNumber);
                }
            }

            foreach (int bomb in bombList)
            {
                int col = bomb / PlayFieldCols;
                int row = bomb % PlayFieldRows;
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = PlayFieldCols;
                }
                else
                {
                    row++;
                }
                BombField[col, row - 1] = '*';
            }

            return BombField;
        }

        /// <summary>
        /// Print play field
        /// </summary>
        /// <param name="playField"></param>
        public void PrintPlayField(char[,] playField)
        {       
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < PlayFieldRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < PlayFieldCols; j++)
                {
                    Console.Write("{0} ", playField[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
            Console.ResetColor();
        }
    }
}
