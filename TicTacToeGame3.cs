using System;
using System.Collections.Generic;
using System.Text;

namespace TIC_TAC_TOE
{
    class TicTacToeGame3
    {
        //declaring 1d array
        char[] board = new char[10];

        //assigning empty values in place of each element
        public void CreateBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }

        //method for choosing letter
        public void ChooseLetter()
        {
            char playerLetter;
            char computerLetter;
            Console.WriteLine("Enter 1 for--->X\nEnter 2 for--->O\nChoose your Letter--> ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                playerLetter = 'X';
                computerLetter = 'O';
                Console.WriteLine("Player Letter is:" + playerLetter);
                Console.WriteLine("Computer Letter is:" + computerLetter);
            }
            else if (choice == 2)
            {
                playerLetter = 'O';
                computerLetter = 'X';
                Console.WriteLine("Player Letter is:" + playerLetter);
                Console.WriteLine("Computer Letter is:" + computerLetter);
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2 only");
            }
        }

        public void ShowBoard()
        {
            Console.WriteLine("  " + board[1] + " | " + board[2] + " | " + board[3] + "  ");
            Console.WriteLine("---|--|---");
            Console.WriteLine("  " + board[4] + " | " + board[5] + " | " + board[6] + "  ");
            Console.WriteLine("---|--|---");
            Console.WriteLine("  " + board[7] + " | " + board[8] + " | " + board[9] + "  ");
        }
    }
}
