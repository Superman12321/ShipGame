using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    internal class Player
    {
        public bool PlayerMove(char[,] Tab, char[,] Tab1)
        {
            int x;
            int y;
            int j = 0;

            do
            {

                if (j > 0) { Console.Write("Try again: "); }

                j += 1;

                Console.Write("x: ");
                int.TryParse(Console.ReadLine(), out x);
                Console.Write("y: ");
                int.TryParse(Console.ReadLine(), out y);
            } while (x > 9 || x < 0 || y > 9 || y < 0 || Tab[x, y] == 'o' || Tab[x, y] == 'x');

            if (Tab1[x, y] == '#')
            {
                Tab[x, y] = 'x';
                Tab1[x, y] = 'x';

                return true;
            }
            else { Tab[x, y] = 'o'; return false; }
        }
        public bool CheckGame(char[,] Tab1, char[,] Tab2)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Tab2[i, j] == '#')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
