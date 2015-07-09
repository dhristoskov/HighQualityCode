using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public static class Messages
    {

        /// <summary>
        /// Const messages used in the game
        /// </summary>
        public const string EndGameMessage = "You detonated a bomb the game is over";
        public const string EnterNameMessage = "Please eneter a name:";
        public const string InputMessage = "Please enter your choice - row and col!";
        public const string WonGameMessage = "You win the game!";


        /// <summary>
        /// Intro message
        /// </summary>
        public static void PrintIntroMessage()
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.SetCursorPosition(15,0);
            Console.WriteLine("Let's play \"Minesweeper\"");
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Try to clear the play field without detonate a bomb");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Type - \"Board\" - to see the Score Board");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Type - \"Restart\" - to start a new game");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("Type - \"Exit\" - for exiting the game");
            Console.ResetColor();
        }

        /// <summary>
        /// Outro nessage
        /// </summary>
        public static void PrintOutroMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("GAME EXIT");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("Thank you for playing!");
            Console.ResetColor();
        }
    }
}
