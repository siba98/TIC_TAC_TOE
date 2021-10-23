using System;
using System.Collections.Generic;
using System.Text;

namespace TIC_TAC_TOE
{
    public class TicTacToeGame2
    {
        //declaring 1d array
        char[] board = new char[10];

        //assigning empty values in place of each element
        public static void CreateBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }

        public static void ChooseLetter()
        {
            Console.WriteLine("Enter 1 for--->X\nEnter 2 for--->O\nChoose your Letter--> ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice==1)
            {
                int playerletter = 'X';
                int computerLetter = 'O';
                Console.WriteLine("Player Letter is:" + playerletter);
                Console.WriteLine("Computer Letter is:" + computerLetter);
            }
            else if(choice==2)
            {
                int PlayerLetter = 'O';
                int CompterLetter = 'X';
                Console.WriteLine("Player Letter is:" + PlayerLetter);
                Console.WriteLine("Computer Letter is:" + CompterLetter);
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2 only");
            }
        }
    }
}
