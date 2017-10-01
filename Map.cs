using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    public class Map
    {
        public void TheMap()
        {
            //Bygga karta.
            int playerX = 3;
            int playerY = 3;

            const int ROWS = 10;
            const int COLUMNS = 20;

            char[,] theMap = new char[COLUMNS, ROWS];

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    if (row == 0 || row == ROWS - 1 || column == 0 || column == COLUMNS - 1)
                    {
                        theMap[column, row] = Wall.WallSign;
                    }
                    else if (row == 4 && column == 9 ||
                             row == 4 && column == 10 ||
                             row == 4 && column == 11 ||
                             row == 4 && column == 12 ||
                             row == 4 && column == 13 ||
                             row == 4 && column == 14 ||
                             row == 4 && column == 16 ||
                             row == 4 && column == 17 ||
                             row == 4 && column == 18 ||
                             row == 3 && column == 9 ||
                             row == 2 && column == 9 ||
                             row == 1 && column == 9 ||
                             row == 6 && column == 9 ||
                             row == 7 && column == 9 ||
                             row == 8 && column == 9
                             )
                    {
                        theMap[column, row] = Wall.WallSign;
                    }

                    else if (row == 5 && column == 9 || row == 4 && column == 15)
                    {
                        theMap[column, row] = Door.DoorSign;

                    }
                    else if (row == 4 && column == 5)
                    {
                        theMap[column, row] = RoomWithKey.RoomSign;
                    }
                    else
                    {
                        theMap[column, row] = Floor.FloorSign;
                    }

                }
            }

            while (true)
            {
                //Röra sig i spelet.
                int row;
                int column;

                string buffer = "";
                for (row = 0; row < ROWS; row++)
                {
                    string line = "";
                    for (column = 0; column < COLUMNS; column++)
                    {
                        if (column == playerX && row == playerY)
                            line += Player.PlayerSign;
                        else
                            line += theMap[column, row];
                    }
                    buffer += line + "\n";
                }

                bool CanPass(int playerx, int playery)
                {
                    if (theMap[playerx, playery] == Wall.WallSign)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.Write($"{buffer}");

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                Console.WriteLine(pressedKey.Key.ToString());
                if (pressedKey.Key.ToString() == "A")
                {
                    if (playerX != 1 && CanPass(playerX - 1, playerY))
                    {
                        Counter.AddMoves();
                        playerX--;
                    }
                }
                else if (pressedKey.Key.ToString() == "S")
                {
                    if (playerY != ROWS - 2 && CanPass(playerX, playerY + 1))
                    {
                        Counter.AddMoves();
                        playerY++;
                    }
                }
                else if (pressedKey.Key.ToString() == "D")
                {
                    if (playerX != COLUMNS - 2 && CanPass(playerX + 1, playerY))
                    {
                        Counter.AddMoves();
                        playerX++;
                    }
                }
                else if (pressedKey.Key.ToString() == "W")
                {
                    if (playerY != 1 && CanPass(playerX, playerY - 1))
                    {
                        Counter.AddMoves();
                        playerY--;
                    }
                }


            }


        }

    }
}
