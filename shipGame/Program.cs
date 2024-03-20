using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1Wins = 0;
            int player2Wins = 0;

            string Move;
            string Choose2;

            bool Check = false;
            bool GameCheck = false;


            Board board = new Board();
            Player players = new Player();
            Ship ships = new Ship();

            Console.WriteLine("Welcome to the ship game!!!");
            Console.WriteLine("o = Miss || x = Hit");
            Console.WriteLine("x = v  ||  y = > ");
            Console.WriteLine("Number of ships: 1 = Four-masted ship || 2 = Three-masted ship || 3 = Two-masted ship || 4 = one-masted ship\n");
            do
            {
                char[,] Tab1 = new char[10, 10];
                char[,] Tab2 = new char[10, 10];

                char[,] TabCheck1 = new char[10, 10];
                char[,] TabCheck2 = new char[10, 10];

                Console.Write("Player1Wins: " + player1Wins + " || ");
                Console.WriteLine("Player2Wins: " + player2Wins);

                Console.WriteLine("[Player 1]");

                board.BoardGame(Tab1);
                Ship.setShips(Tab1);

                Console.Clear();

                Console.WriteLine("[Player 2]");
                board.BoardGame(Tab2);
                Ship.setShips(Tab2);

                Console.Clear();

                do
                {
                    Console.WriteLine("Move Player1...");
                    Move = Console.ReadLine();

                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Your move PLAYER1:");

                        board.BoardGame(Tab1);
                        board.GuessBoardGame(TabCheck1);

                        Check = players.PlayerMove(TabCheck1, Tab2);
                        GameCheck = players.CheckGame(Tab1, Tab2);

                        if (GameCheck)
                        {
                            break;
                        }

                        Console.Clear();

                        if (Check == true) { Console.WriteLine("Hit"); }
                    } while (Check);

                    Check = false;

                    Console.Clear();

                    if (GameCheck)
                    {
                        break;
                    }

                    Console.WriteLine("Move Player2...");
                    Move = Console.ReadLine();

                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Your move PLAYER2:");

                        board.BoardGame(Tab2);
                        board.GuessBoardGame(TabCheck2);

                        Check = players.PlayerMove(TabCheck2, Tab1);
                        GameCheck = players.CheckGame(Tab2, Tab1);

                        if (GameCheck)
                        {
                            break;
                        }

                        Console.Clear();

                        if (Check == true) { Console.WriteLine("Hit"); }
                    } while (Check);

                    Check = false;

                    Console.Clear();


                } while (!GameCheck);

                Console.Clear();

                if (GameCheck)
                {
                    if (players.CheckGame(Tab1, Tab2))
                    {
                        Console.WriteLine("Win Player 1");
                        player1Wins++;
                    }
                    else if (players.CheckGame(Tab2, Tab1))
                    {
                        Console.WriteLine("Win Player 2");
                        player2Wins++;
                    }
                    Console.WriteLine("Player 1 has won " + player1Wins + ", and Player 2 has won " + player2Wins);
                }

                Console.WriteLine("You want to play the game again :) :yes || no\n");

                Choose2 = Console.ReadLine();


            } while (Choose2 == "yes");

            Console.Write("Player1Wins: " + player1Wins + " || ");
            Console.WriteLine("Player2Wins: " + player2Wins);
            Console.ReadKey();
        }
    }
}
