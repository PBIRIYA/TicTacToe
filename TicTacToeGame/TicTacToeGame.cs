using System;
using System.Collections.Generic;
using System.Text;
namespace TicTacToeGame
{
    class TicTacToeGame
    {
        public char[] Board { get; set; }
        public char Player { get; set; }
        public char Computer { get; set; }
        public void InitializeBoard()
        {
            Board = new char[10];
            for (int i = 1; i < 10; i++)
                Board[i] = ' ';
        }
        public char ChooseOption()
        {
            Console.Write("Choose X or O : ");
            var input = Convert.ToChar(Console.ReadLine());
            return (input == 'X' || input == 'O') ? input : ChooseOption();
        }
    }
}