using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };


            void PrintBoard()
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    Console.WriteLine("\n-------------");
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (j == 0)
                            Console.Write("| ");
                        Console.Write(board[i, j] + " | ");
                    }
                    if (i == 2)
                        Console.WriteLine("\n-------------");
                }
            }

            

            void X_Player_Turn() {
                //Console.WriteLine("Please enter the row in which you want to mark X:");
                //int user_row_choice = int.Parse(Console.ReadLine()) - 1;
                ////Console.WriteLine(user_row_choice);
                //Console.WriteLine("Please enter the column in which you want to mark X:");
                //int user_column_choice = int.Parse(Console.ReadLine()) - 1;
                ////Console.WriteLine(user_column_choice);
                //board[user_row_choice, user_column_choice] = "X";
                Console.WriteLine("\nPlease enter the number where you want to write X:");
                int user_choice = int.Parse(Console.ReadLine()) - 1; // For computer indeces.
                int column = user_choice % 3;
                int row = user_choice / 3;
                if (0 > row || row > 2 || column < 0) // If the user enters 0. user_choice is -1 and row is 0. So I check the column.
                {
                    Console.WriteLine("Please enter a value between 1 and 9.");
                    X_Player_Turn();
                }
                else if (board[row, column] != "X" && board[row, column] != "O")
                {
                    board[row, column] = "X";
                }
                else
                {
                    Console.WriteLine("That position is already marked.");
                    X_Player_Turn();
                }
            }

            void O_Player_Turn()
            {
                //Console.WriteLine("Please enter the row in which you want to mark O:");
                //int user_row_choice = int.Parse(Console.ReadLine()) - 1;
                ////Console.WriteLine(user_row_choice);
                //Console.WriteLine("Please enter the column in which you want to mark O:");
                //int user_column_choice = int.Parse(Console.ReadLine()) - 1;
                ////Console.WriteLine(user_column_choice);
                //board[user_row_choice, user_column_choice] = "O";
                Console.WriteLine("\nPlease enter the number where you want to write O:");
                int user_choice = int.Parse(Console.ReadLine()) - 1;
                int column = user_choice % 3;
                int row = user_choice / 3;

                if (0 > row || row > 2 || column < 0)
                {
                    Console.WriteLine("Please enter a value between 1 and 9.");
                    O_Player_Turn();
                }
                else if (board[row, column] != "X" && board[row, column] != "O")
                {
                    board[row, column] = "O";
                }
                else
                {
                    Console.WriteLine("That position is marked already.");
                    O_Player_Turn();
                }
            }
            bool Checker()
            {
                void WinnerNamePrinter(string playerMark)
                {
                    Console.WriteLine($"The {playerMark} player wins!");
                }

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    // Checks for rows.
                    if (board[i, 0] == "O" & board[i, 1] == "O" & board[i, 2] == "O") //,board[i,1], board[i,2]
                    {
                        WinnerNamePrinter(board[i, 0]);
                        return true;
                    }
                    if (board[i, 0] == "X" && board[i, 1] == "X" && board[i, 2] == "X") //,board[i,1], board[i,2]
                    {
                        WinnerNamePrinter(board[i, 0]);
                        return true;
                    }
                    //Checks for columns
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[0, j] == "O" && board[1, j] == "O" && board[2, j] == "O")
                        {
                            WinnerNamePrinter(board[0, j]);
                            return true;
                        }
                        if (board[0, j] == "X" && board[1, j] == "X" && board[2, j] == "X")
                        {
                            WinnerNamePrinter(board[0, j]);
                            return true;
                        }
                    }
                }

                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    WinnerNamePrinter(board[0, 0]);
                    return true;
                }
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    WinnerNamePrinter(board[0, 2]);
                    return true; 
                }

                return false;
            }


            while (!Checker()) 
            {
                PrintBoard();
                X_Player_Turn();
                if (Checker())
                {
                    break;
                }
                PrintBoard();
                O_Player_Turn();
            }
            

        }
    }
}