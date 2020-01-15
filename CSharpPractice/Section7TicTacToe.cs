using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Section7TicTacToe
    {

        static string[,] gameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        static string[] gameBoardOneDimension = new string[10];
        static bool isPlayerXTurn = false;
        static bool gameOver = false;
        static string winner;
        static int movesLeft = 8;

        public static void PlayTicTacToe()
        {
            UpdateGameBoard(gameBoard, null);
            Console.WriteLine("Begin game");

            // Main game loop
            while (gameOver == false)
            {
                // Ask for input
                if (isPlayerXTurn)
                    Console.WriteLine("Player X, what is your move? (Enter 1-9)");
                else
                    Console.WriteLine("Player O, what is your move? (Enter 1-9)");
                string input = Console.ReadLine();

                // Validate and check input
                if (!ValidateUserInput(input))
                {
                    Console.WriteLine("You must choose a number from 1-9. Pick again.");
                    continue;
                }
                else if (CheckIfMoveWasAlreadyMade(input))
                {
                    Console.WriteLine("Move already taken. Choose another.");
                    continue;
                }
                else
                {
                    UpdateGameBoard(gameBoard, input);
                    movesLeft--;
                }                  
            }

            Console.WriteLine("Game over.");
            if (winner != null)
                Console.WriteLine("Player {0} wins!", winner);
            else
            {
                Console.WriteLine("Stalemate.");
            }
        }

        public static bool ValidateUserInput(string input)
        {
            bool success = int.TryParse(input, out int parsedValue);
            if (success && parsedValue > 0 && parsedValue < 10)
                return true;
            else
                return false;
        }

        public static bool CheckIfMoveWasAlreadyMade(string playerMove)
        {
            if (gameBoardOneDimension[Int32.Parse(playerMove) - 1] == "X" || gameBoardOneDimension[Int32.Parse(playerMove) - 1] == "O")
                return true;
            else
                return false;
        }

        public static void SwitchPlayers()
        {
            isPlayerXTurn = !isPlayerXTurn;
        }
        public static void RedrawGameBoard(string[] gameBoardOneDimension)
        {
            Console.Clear();
            string[] a = gameBoardOneDimension;
            // Designed to match the number pad
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |       ");
            Console.WriteLine("  " + a[6] + "  |  " + a[7] + "  |  " + a[8]);
            Console.WriteLine("     |     |       ");
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |       ");
            Console.WriteLine("  " + a[3] + "  |  " + a[4] + "  |  " + a[5]);
            Console.WriteLine("     |     |       ");
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |       ");
            Console.WriteLine("  " + a[0] + "  |  " + a[1] + "  |  " + a[2]);
            Console.WriteLine("     |     |       ");
            Console.WriteLine("------------------");
        }
        public static void UpdateGameBoard(string[,] gameBoard, string playerMove)
        {
            // Convert 2d array to 1d array, then pass to PrintGameBoard
            // Create counter variable to get the proper index of gameBoardOneDimension inside the nested loop
            int counter = -1;
            // Then iterate over a 2d array, by columns first, then by row, using the built in GetLength property of the 2D array
            for (int col = 0; col < gameBoard.GetLength(0); col++)
            {
                for (int row = 0; row < gameBoard.GetLength(1); row++)
                {
                    counter++;                 

                    // Check if the player's move matches the element and if so, replace with that move in both arrays
                    if (playerMove == gameBoard[col, row])
                    {
                        
                        if (isPlayerXTurn)
                        {
                            gameBoardOneDimension[counter] = "X";
                            gameBoard[col, row] = "X";
                        }
                        else
                        {
                            gameBoardOneDimension[counter] = "O";
                            gameBoard[col, row] = "O";
                        }
                    }
                    else
                    {
                        gameBoardOneDimension[counter] = gameBoard[col, row]; // Assigning each element in order to a 1D array
                    }
                }
            }
            SwitchPlayers();
            RedrawGameBoard(gameBoardOneDimension);
            CheckIfGameOver();
        }

        public static bool CheckIfGameOver()
        {
            // Check for stalemate
            if (movesLeft == 0)
            {
                return gameOver = true;
            }

            // Then check for winner
            for (int i = 0; i < 3 ; i++)
            {
                // Check all rows for a win
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
                {
                    winner = gameBoard[i, 0];
                    return gameOver = true;

                }
                // Check all columns for a win
                if (gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
                {
                    winner = gameBoard[0, i];
                    return gameOver = true;
                }

            }

            // Check crosses for a win
            if (gameBoard[0,0] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2, 2])
            {
                winner = gameBoard[0, 0];
                return gameOver = true;

            }
            if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
            {
                winner = gameBoard[0, 2];
                return gameOver = true;
            }
            
            return false;
        }
    }
}
