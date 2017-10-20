using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;


namespace Labb4_enLitenUpdate
{
    
    public class Map
    {
        
        //Uppbyggnad av kart-array + on/off-funktion för spel
        private const int ROWS = 10;
        private const int COLUMNS = 20;
        char[,] TheMap = new char[COLUMNS, ROWS];

        private bool gameOn;
        public bool GameOn { get { return gameOn; } set { gameOn = value; } }


        //startvärde för player
        private int startValueForPlayerX;
        private int startValueForPlayerY;

        //Instansiering av objekt utanför kartklass för använding i densamma
        Counter c = new Counter();
        RoomWithKey r = new RoomWithKey();
        Keys k = new Keys();

        //Egenskaper för tecken + motsvarnade setters
        private char wallSign = 'a'; public char WallSign { get { return wallSign; } set { wallSign = value; } }
        private char floorSign = 'a'; public char FloorSign { get { return floorSign; } set { floorSign = value; } }
        private char playerSign = 'a'; public char PlayerSign { get { return playerSign; } set { playerSign = value; } }
        private char doorSign = 'a'; public char DoorSign { get { return doorSign; } set { doorSign = value; } }
        private char exitSign = 'a'; public char ExitSign { get { return exitSign; } set { exitSign = value; } }
        private char monsterSign = 'a'; public char MonsterSign { get { return monsterSign; } set { monsterSign = value; } }
        private char roomWithKeySign = 'a'; public char RoomWithKeySign { get { return roomWithKeySign; } set { roomWithKeySign = value; } }

        //metoder för att hämta tecken från teckenklasserna och initiera tecken-egenskaperna för kartklassen:
        public void FetchWallSign() { Wall w = new Wall(); WallSign = w.SendSign(); }
        public void FetchFloorSign() { Floor f = new Floor(); FloorSign = f.SendSign(); }
        public void FetchPlayerSign() { Player p = new Player(); PlayerSign = p.PlayerSign; }
        public void FetchDoorSign() { Door d = new Door(); DoorSign = d.SendSign(); }
        public void FetchExitSign() { Exit e = new Exit(); ExitSign = e.SendSign(); }
        public void FetchMonsterSign() { Monster m = new Monster(); MonsterSign = m.SendSign(); }
        public void FetchRoomWithKeySign() { RoomWithKey r = new RoomWithKey(); RoomWithKeySign = r.SendSign(); }


        //Skapar kartan och lägger in tecken.
        public void RenderMap()  
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    if (row == 0 || row == 9 || column == 0 || column == 19)
                    {
                        TheMap[column, row] = WallSign;
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
                        TheMap[column, row] = WallSign;
                    }
                    else if (row == 5 && column == 9 || row == 4 && column == 15)
                    {
                        TheMap[column, row] = DoorSign;

                    }
                    else if (row == 4 && column == 5 || row == 1 && column == 8)
                    {
                        TheMap[column, row] = RoomWithKeySign;
                    }

                    else if (row == 7 && column == 17 || row == 4 && column == 8 || row == 8 && column == 3)
                    {
                        TheMap[column, row] = MonsterSign;
                    }
                    else if (row == 2 && column == 18)
                    {
                        TheMap[column, row] = ExitSign;
                    }
                    else
                    {
                        TheMap[column, row] = FloorSign;
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
                            Console.Write(PlayerSign);
                        }
                        else if (jj == startValueForPlayerY && ii == startValueForPlayerX || jj == startValueForPlayerY - 1 && ii == startValueForPlayerX || jj == startValueForPlayerY + 1 && ii == startValueForPlayerX ||
                            jj == startValueForPlayerY && ii == startValueForPlayerX - 1 || jj == startValueForPlayerY && ii == startValueForPlayerX + 1 || jj == startValueForPlayerY - 1 && ii == startValueForPlayerX - 1 ||
                            jj == startValueForPlayerY - 1 && ii == startValueForPlayerX + 1 || jj == startValueForPlayerY + 1 && ii == startValueForPlayerX - 1 || jj == startValueForPlayerY + 1 && ii == startValueForPlayerX + 1 ||
                            ii == rows - 1 || ii == 0 || jj == cols - 1 || jj == 0)
                        {
                            Console.Write(TheMap[ii, jj]);
                        }

                        else
                        {
                            Console.Write(" ");
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

                    if (TheMap[playerx, playery] == r.RoomSign)
                    {
                        //Golv
                        c.AddKeys();
                        TheMap[playerx, playery] = FloorSign;
                        return true;
                    }
                    else if (TheMap[playerx, playery] == WallSign)
                    {
                        //Vägg
                        c.AnnounceMoves();
                        return false;
                    }

                    else if (TheMap[playerx, playery] == ExitSign)
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
                    else if (TheMap[playerx, playery] == DoorSign)
                    {
                        //Låst dörr - Har nyckel
                        if (c.HasKey())
                        {
                            c.RemoveKeys();
                            TheMap[playerx, playery] = FloorSign;
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
                    else if (TheMap[playerx, playery] == MonsterSign)
                    {
                        TheMap[playerx, playery] = FloorSign;
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

            FetchWallSign();

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    Console.Write($"{WallSign}");
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
            //initiering av tecknen för kartan vid instansiering av objekt
            FetchWallSign();
            FetchFloorSign();
            FetchPlayerSign();
            FetchDoorSign();
            FetchExitSign();
            FetchMonsterSign();
            FetchRoomWithKeySign();

            //Initering av egenskaper för kartan
            GameOn = true;
            startValueForPlayerX = 2;
            startValueForPlayerY = 2;
        }
    }
}

