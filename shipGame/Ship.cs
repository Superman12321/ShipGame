using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    internal class Ship
    {
        public static int setShips(char[,] Tab)
            {

            int y = 0;
            int x = 0;
            int direction = 0;
            int j = 0;
            int size = 0;

                for (int a = 0; a < 1; a++)
                {
                    LenghtShips(Tab, 4, x, y, direction, j);
                }
                for (int a = 0; a < 2; a++)
                {
                    LenghtShips(Tab, 3, x, y, direction, j);
                }
                for (int a = 0; a < 3; a++)
                {
                    LenghtShips(Tab, 2, x, y, direction, j);
                }
                for (int a = 0; a < 4; a++)
                {
                    LenghtShips(Tab, 1, x, y, direction, j);
                }

                return size;
            }
            private static void LenghtShips(char[,] Tab, int size, int x, int y, int direction, int j)
        {

            Board board = new Board();

            Console.WriteLine("Arrange the ship:");
            Console.WriteLine("" + size + "-masted ship:");

            if (size > 1)
            {
                do
                {
                    if (j > 0) { Console.Write("Try again: "); }

                    j += 1;

                    Console.Write("1-Horizontally || 2-Vertically: ");
                    int.TryParse(Console.ReadLine(), out direction);
                } while (direction > 2 || direction < 1);
            }
            j = 0;

            do
            {

                if (j > 0) { Console.Write("Try again: "); }

                j += 1;

                Console.Write("x: ");
                int.TryParse(Console.ReadLine(), out x);
                Console.Write("y: ");
                int.TryParse(Console.ReadLine(), out y);
            } while (x > 9 || x < 0 || y > 9 || y < 0);

            j = 0;

            if (direction == 1)
            {
                while (y > 10 - size || x > 9)
                {
                    Console.Write("Try again: ");

                    Console.Write("x: ");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.Write("y: ");
                    int.TryParse(Console.ReadLine(), out y);
                }

                while ((y + size < Tab.GetLength(1) && Tab[x, y + size] == '#') ||
                       (y - 1 >= 0 && Tab[x, y - 1] == '#') ||
                       (x + 1 < Tab.GetLength(0) && Tab[x + 1, y] == '#') ||
                       (x - 1 >= 0 && Tab[x - 1, y] == '#') ||
                       (x + 1 < Tab.GetLength(0) && y + 2 < Tab.GetLength(1) && Tab[x + 1, y + 2] == '#') ||
                       (x - 1 >= 0 && y + 2 < Tab.GetLength(1) && Tab[x - 1, y + 2] == '#') ||
                       (x + 1 < Tab.GetLength(0) && y + 1 < Tab.GetLength(1) && Tab[x + 1, y + 1] == '#') ||
                       (x - 1 >= 0 && y + 1 < Tab.GetLength(1) && Tab[x - 1, y + 1] == '#') ||
                       (x + 1 < Tab.GetLength(0) && y + size < Tab.GetLength(1) && Tab[x + 1, y + size] == '#') ||
                       (x - 1 >= 0 && y + size < Tab.GetLength(1) && Tab[x - 1, y + size] == '#') ||
                       (x + 1 < Tab.GetLength(0) && y - 1 >= 0 && Tab[x + 1, y - 1] == '#') ||
                       (x - 1 >= 0 && y - 1 >= 0 && Tab[x - 1, y - 1] == '#'))
                {
                    Console.WriteLine("Try again");

                    Console.Write("x: ");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.Write("y: ");
                    int.TryParse(Console.ReadLine(), out y);

                }

                for (int i = 0; i < size; i++)
                {
                    Tab[x, y + i] = '#';
                }
            }
            else
            {
                while (x > 10 - size || y > 9)
                {
                    Console.WriteLine("Try again");

                    Console.Write("x: ");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.Write("y: ");
                    int.TryParse(Console.ReadLine(), out y);

                }

                while ((x + size < Tab.GetLength(0) && Tab[x + size, y] == '#') ||
               (x - 1 >= 0 && Tab[x - 1, y] == '#') ||
               (y + 1 < Tab.GetLength(1) && Tab[x, y + 1] == '#') ||
               (y - 1 >= 0 && Tab[x, y - 1] == '#') ||
               (x + 2 < Tab.GetLength(0) && y + 1 < Tab.GetLength(1) && Tab[x + 2, y + 1] == '#') ||
               (x + 2 < Tab.GetLength(0) && y - 1 >= 0 && Tab[x + 2, y - 1] == '#') ||
               (x + 1 < Tab.GetLength(0) && y + 1 < Tab.GetLength(1) && Tab[x + 1, y + 1] == '#') ||
               (x + 1 < Tab.GetLength(0) && y - 1 >= 0 && Tab[x + 1, y - 1] == '#') ||
               (x + size < Tab.GetLength(0) && y + 1 < Tab.GetLength(1) && Tab[x + size, y + 1] == '#') ||
               (x + size < Tab.GetLength(0) && y - 1 >= 0 && Tab[x + size, y - 1] == '#') ||
               (x - 1 >= 0 && y + 1 < Tab.GetLength(1) && Tab[x - 1, y + 1] == '#') ||
               (x - 1 >= 0 && y - 1 >= 0 && Tab[x - 1, y - 1] == '#'))
                {
                    Console.WriteLine("Try again");

                    Console.Write("x: ");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.Write("y: ");
                    int.TryParse(Console.ReadLine(), out y);
                }

                for (int i = 0; i < size; i++)
                {
                    Tab[x + i, y] = '#';

                }
            }

            Console.Clear();
            board.BoardGame(Tab);
        }
    }
}