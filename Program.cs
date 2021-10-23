using System;

namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome to TIC TAC TOE ****************\n");

            //creating object of the class
            TicTacToeGame obj = new TicTacToeGame();
            //calling method with the obj variable
            obj.CreateBoard();


            //UC2
            TicTacToeGame2.CreateBoard();
            TicTacToeGame2.CreateBoard();

        }
    }
}
