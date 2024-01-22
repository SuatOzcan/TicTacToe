using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };


            void PrintBoard()
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.WriteLine("\n-------------");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == 0)
                            Console.Write("| ");
                        Console.Write(matrix[i, j] + " | ");
                    }
                    if (i == 2)
                        Console.WriteLine("\n-------------");
                }
            }

            PrintBoard();
            X_Player_Turn();
            Y_player_Turn

            void X_Player_Turn() { 
                Console.WriteLine("Please enter the row in which you want to mark X:");
                int user_row_choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(user_row_choice);
                Console.WriteLine("Please enter the column in which you want to mark X:");
                int user_column_choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(user_column_choice);
                matrix[user_row_choice, user_column_choice] = "X";
            }

            void Y_player_Turn()
            {
                Console.WriteLine("Please enter the row in which you want to mark Y:");
                int user_row_choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(user_row_choice);
                Console.WriteLine("Please enter the column in which you want to mark Y:");
                int user_column_choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(user_column_choice);
                matrix[user_row_choice, user_column_choice] = "X";
            }


        }
    }
}