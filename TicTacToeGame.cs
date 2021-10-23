using System;
using System.Collections.Generic;
using System.Text;

namespace TIC_TAC_TOE
{
    class TicTacToeGame
    {
        //declaring 1d array
        char[] board = new char[10];

        public void CreateBoard()
        {
            for(int i =1; i<board.Length; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
