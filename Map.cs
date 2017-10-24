using System;
using System.Threading;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Labb4_enLitenUpdate
{
    
    public class Map
    {

        //Uppbyggnad av kart-array + on/off-funktion för spel
        private const int ROWS = 10;
        private const int COLUMNS = 20;
        Square[,] TheMap = new Square[COLUMNS, ROWS];


        Counter c = new Counter();
        RoomWithKey r = new RoomWithKey();
        Keys k = new Keys();
        Wall w = new Wall();
        Door d = new Door();
        Monster m = new Monster();
        Exit e = new Exit();
        Player p = new Player();
        Floor f = new Floor();
        private bool gameOn;
        public bool GameOn { get { return gameOn; } set { gameOn = value; } }


        //startvärde för player
        private int startValueForPlayerX;
        private int startValueForPlayerY;

        //Skapar kartan och lägger in tecken.
        public void RenderMap()  
            
        {

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    if (row == 0 || row == 9 || column == 0 || column == 19)
                    {
                        TheMap[column, row] = w;
                    }
                    else if (
                             row == 4 && column == 9 ||
                             row == 4 && column == 10 ||
                             row == 4 && column == 11 ||
                             row == 4 && column == 12 ||
                             row == 4 && column == 13 ||
                             row == 4 && column == 14 ||
                             row == 4 && column == 16 ||
                             row == 4 && column == 17 ||
                             row == 4 && column == 18 ||
                             row == 3 && column == 9 ||
                             row == 3 && column == 1 ||
                             row == 3 && column == 2 ||
                             row == 3 && column == 3 ||
                             row == 3 && column == 4 ||
                             row == 3 && column == 5 ||
                             row == 3 && column == 6 ||
                             row == 3 && column == 8 ||
                             row == 2 && column == 9 ||
                             row == 1 && column == 9 ||
                             row == 6 && column == 9 ||
                             row == 7 && column == 9 ||
                             row == 8 && column == 9
                             )
                    {
                        TheMap[column, row] = w;
                    }
                    else if (row == 5 && column == 9 || row == 4 && column == 15)
                    {
                        TheMap[column, row] = d;

                    }
                    else if (row == 4 && column == 5 || row == 1 && column == 8)
                    {
                        TheMap[column, row] = r;
                    }

                    else if (row == 7 && column == 17 || row == 4 && column == 8 || row == 8 && column == 3)
                    {
                        TheMap[column, row] = m;
                    }
                    else if (row == 2 && column == 18)
                    {
                        TheMap[column, row] = e;
                    }
                    else
                    {
                        TheMap[column, row] = f;
                    }
                }
            }
        }

        //Ritar ut kartan
        public void UpdateMap()   
        {
            while (GameOn == true)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = 0;

                int rows = TheMap.GetLength(0);
                int cols = TheMap.GetLength(1);
                for (int jj = 0; jj < cols; jj++)
                {
                    for (int ii = 0; ii < rows; ii++)
                    {
                        if (ii == startValueForPlayerX && jj == startValueForPlayerY)
                        {
                           p.Draw();
                        }
                        else
                        {
                       
                            TheMap[ii,jj].Draw();
                        }


                    }
                    Console.WriteLine();
                }
                //Kolla vad som sker vid tecken-interaktion och om man kan passera.

                bool CanPass(int playerx, int playery)
                {
                    if(c.Points == 0)
                    {
                        //Slut på poäng - Game over.
                        GameOn = false;
                        GamoOver();
                        c.setCursor(3, 1);
                        Console.Write($"Out of points!");
                        c.setCursor(2, 5);
                        Thread.Sleep(1500);
                        Console.Write($"G A M E  O V E R");
                        return false;
                    }

                    if (TheMap[playerx, playery] == r)
                    {
                        //Golv
                        c.AddKeys();
                        TheMap[playerx, playery] = f;
                        return true;
                    }
                    else if (TheMap[playerx, playery] == w)
                    {
                        //Vägg
                        c.AnnounceMoves();
                        return false;
                    }

                    else if (TheMap[playerx, playery] == e)
                    {
                        //Hittat utgången
                        GameOn = false;
                        GamoOver();
                        c.setCursor(4, 1);
                        Console.Write($"You did it!");
                        Thread.Sleep(2500);
                        c.setCursor(2, 5);
                        Console.Write($"G A M E  O V E R");
                        return true;
                    }
                    else if (TheMap[playerx, playery] == d)
                    {
                        //Låst dörr - Har nyckel
                        if (c.HasKey())
                        {
                            c.RemoveKeys();
                            TheMap[playerx, playery] = f;
                            return true;
                        }

                        else
                        {
                        //Låst dörr - Har inte nyckel
                            c.AnnounceMoves();
                            c.setCursor(22, 5);
                            Console.WriteLine($"Blimey! You don't have a key... Find one.");
                            return false;
                        }
                    }
                    //Monster
                    else if (TheMap[playerx, playery] == m)
                    {
                        TheMap[playerx, playery] = f;
                        c.MonsterTakesPoints();
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }

                //Spelarrörelse

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                Console.WriteLine(pressedKey.Key.ToString());
                Console.Clear();
                if (pressedKey.Key.ToString() == "A")
                {
                    if (startValueForPlayerX != 1 && CanPass(startValueForPlayerX - 1, startValueForPlayerY))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        startValueForPlayerX--;
                    }
                }
                else if (pressedKey.Key.ToString() == "S")
                {
                    if (startValueForPlayerY != ROWS - 2 && CanPass(startValueForPlayerX, startValueForPlayerY + 1))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        startValueForPlayerY++;
                    }
                }
                else if (pressedKey.Key.ToString() == "D")
                {
                    if (startValueForPlayerX != COLUMNS - 2 && CanPass(startValueForPlayerX + 1, startValueForPlayerY))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        startValueForPlayerX++;
                    }
                }
                else if (pressedKey.Key.ToString() == "W")
                {
                    if (startValueForPlayerY != 1 && CanPass(startValueForPlayerX, startValueForPlayerY - 1))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        startValueForPlayerY--;
                    }
                }
                else if (pressedKey.Key.ToString() == "Y")
                {
                    Console.WriteLine($"Game Exiting...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
        }
        //Game Over
        public void GamoOver()
        {
            Wall wall = new Wall();
            Map map = new Map();

            

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    Console.Write($"{w.Tile}");
                }
                Console.WriteLine();
            }

            map.GameOn = false;
            Thread.Sleep(3000);
            if(c.Points == 0) 
            Console.WriteLine($"\n\n(Press any key to end.)");
        }
        
        public Map()
        {
            
            //Initering av egenskaper för kartan
            GameOn = true;
            startValueForPlayerX = 2;
            startValueForPlayerY = 2;
        }
    }
}

