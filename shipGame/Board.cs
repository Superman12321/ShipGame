using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    internal class Board
    {
        public void BoardGame(char [,] Tab)
        {

            for (int j = 0; j < 10; j++)
            {
                Console.Write("  "+j);
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("[" + Tab[i, j] + "]");
                }
                Console.Write("\n");
            }
        }
        public void GuessBoardGame(char[,] Tab)
        {

            for (int j = 0; j < 10; j++)
            {
                Console.Write("  "+j);
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("[" + Tab[i,j] + "]");
                }
                Console.Write("\n");
            }
        }
    }
}
