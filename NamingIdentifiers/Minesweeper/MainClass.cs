using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        private static readonly List<Player> LeaderBoard = new List<Player>(6);


        /// <summary>
        /// Print score board
        /// </summary>
        private static void PrintScoreBoard()
        {
            Console.Clear();
            Console.WriteLine("Leader Board:");
            if (LeaderBoard.Count > 0)
            {
                for (int i = 0; i < LeaderBoard.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} opened cells", i + 1, LeaderBoard[i].Name, LeaderBoard[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The Leader Board is empty!");
            }
        }


        /// <summary>
        /// Get number of surrounding bombs
        /// </summary>
        /// <param name="playField"></param>
        private static void GetBombCount(char[,] playField)
        {
            int playFieldColumns = playField.GetLength(0);
            int playFieldRows = playField.GetLength(1);

            for (int i = 0; i < playFieldColumns; i++)
            {
                for (int j = 0; j < playFieldRows; j++)
                {
                    if (playField[i, j] != '*')
                    {
                        char proximity = CalcProximityBomb(playField, i, j);
                        playField[i, j] = proximity;
                    }
                }
            }
        }

        /// <summary>
        /// Set number in cell
        /// </summary>
        /// <param name="playField"></param>
        /// <param name="bomb"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private static void SetBombNumber(char[,] playField, char[,] bomb, int row, int col)
        {
            char bombCount = CalcProximityBomb(bomb, row, col);
            bomb[row, col] = bombCount;
            playField[row, col] = bombCount;
        }

        /// <summary>
        /// Calculate number of 
        /// surrounding bombs
        /// </summary>
        /// <param name="playField"></param>
        /// <param name="playFiledCol"></param>
        /// <param name="playFiledRow"></param>
        /// <returns></returns>
        private static char CalcProximityBomb(char[,] playField, int playFiledCol, int playFiledRow)
        {
            int bombCounter = 0;
            int rows = playField.GetLength(0);
            int cols = playField.GetLength(1);

            if (playFiledCol - 1 >= 0)
            {
                if (playField[playFiledCol - 1, playFiledRow] == '*')
                {
                    bombCounter++;
                }
            }

            if (playFiledCol + 1 < rows)
            {
                if (playField[playFiledCol + 1, playFiledRow] == '*')
                {
                    bombCounter++;
                }
            }

            if (playFiledRow - 1 >= 0)
            {
                if (playField[playFiledCol, playFiledRow - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if (playFiledRow + 1 < cols)
            {
                if (playField[playFiledCol, playFiledRow + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((playFiledCol - 1 >= 0) && (playFiledRow - 1 >= 0))
            {
                if (playField[playFiledCol - 1, playFiledRow - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((playFiledCol - 1 >= 0) && (playFiledRow + 1 < cols))
            {
                if (playField[playFiledCol - 1, playFiledRow + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((playFiledCol + 1 < rows) && (playFiledRow - 1 >= 0))
            {
                if (playField[playFiledCol + 1, playFiledRow - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((playFiledCol + 1 < rows) && (playFiledRow + 1 < cols))
            {
                if (playField[playFiledCol + 1, playFiledRow + 1] == '*')
                {
                    bombCounter++;
                }
            }

            return char.Parse(bombCounter.ToString());
        }

        private static void Main(string[] args)
        {
            const int MaxTurns = 35;
            
            PlayField field = new PlayField();
            char[,] playField = field.CreatePlayField();
            char[,] bombField = field.SetBombInPlayField();
            string command;

            int turnCounter = 0;                
            int playFieldRows = 0;
            int playFieldColumns = 0;

            bool isGameWon = false;
            bool isGameFinished = true;
            bool isDetonated = false;
            
           
            

            do
            {
                if (isGameFinished)
                {
                    Messages.PrintIntroMessage();
                    field.PrintPlayField(playField);
                    isGameFinished = false;
                }

                Console.WriteLine(Messages.InputMessage);
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out playFieldRows) && int.TryParse(command[2].ToString(), out playFieldColumns)
                        && playFieldRows <= playField.GetLength(0) && playFieldColumns <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command.ToLowerInvariant())
                {
                    case "board":                    
                        PrintScoreBoard();
                        break;
                    case "restart":
                        Console.Clear();
                        playField = field.CreatePlayField(); 
                        bombField = field.SetBombInPlayField();
                        field.PrintPlayField(playField);
                        isDetonated = false;
                        isGameFinished = false;
                        break;
                    case "exit":
                        break;
                    case "turn":
                        if (bombField[playFieldRows, playFieldColumns] != '*')
                        {
                            if (bombField[playFieldRows, playFieldColumns] == '-')
                            {
                                SetBombNumber(playField, bombField, playFieldRows, playFieldColumns);
                                turnCounter++;
                            }

                            if (MaxTurns == turnCounter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                field.PrintPlayField(playField);
                            }
                        }
                        else
                        {
                            isDetonated = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalide command!");
                        break;
                }

                if (isDetonated)
                {
                    field.PrintPlayField(bombField);
                    Console.WriteLine(Messages.EndGameMessage);
                    Console.WriteLine(Messages.EnterNameMessage);
                    string name = Console.ReadLine();
                    Player player = new Player(name, turnCounter);
                    if (LeaderBoard.Count < 5)
                    {
                        LeaderBoard.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < LeaderBoard.Count; i++)
                        {
                            if (LeaderBoard[i].Points < player.Points)
                            {
                                LeaderBoard.Insert(i, player);
                                LeaderBoard.RemoveAt(LeaderBoard.Count - 1);
                                break;
                            }
                        }
                    }

                    LeaderBoard.OrderBy(playerUnit => playerUnit.Name);
                    LeaderBoard.OrderBy(playerUnit=>playerUnit.Points);
                    PrintScoreBoard();

                    playField = field.CreatePlayField();
                    bombField = field.SetBombInPlayField();
                    turnCounter = 0;
                    isDetonated = false;
                    isGameFinished = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine(Messages.WonGameMessage);
                    field.PrintPlayField(bombField);
                    Console.WriteLine(Messages.EnterNameMessage);
                    string name = Console.ReadLine();
                    Player player = new Player(name, turnCounter);
                    LeaderBoard.Add(player);
                    PrintScoreBoard();
                    playField = field.CreatePlayField(); 
                    bombField = field.SetBombInPlayField();
                    turnCounter = 0;
                    isGameWon = false;
                    isGameFinished = true;
                }
            }
            while (command.ToLowerInvariant() != "exit");
            Messages.PrintOutroMessage();
        }   
    }
}