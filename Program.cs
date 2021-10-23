using System;

namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome to TIC TAC TOE ****************");

            TicTacToeGame obj = new TicTacToeGame();
            obj.CreateBoard();
        }
    }
}
