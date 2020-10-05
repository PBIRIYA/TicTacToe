using System;
namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.InitializeBoard();
            ticTacToeGame.Player = ticTacToeGame.ChooseOption();
            ticTacToeGame.Computer = ticTacToeGame.Player == 'X' ? 'O' : 'X';
        }
    }
}