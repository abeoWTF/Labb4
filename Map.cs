using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    public class Map
    {
        //Till kartan:
        private const int ROWS = 10;
        private const int COLUMNS = 20;
        char[,] theMap = new char[COLUMNS, ROWS];

        //startvärde för player
        private int playerX = 2;
        private int playerY = 2;

        //Instansiera
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
        
        //Funktioner?
        //Tar emot indaata från bl.a spelarklassen och även kartans olika tecken/delar från hierarkin
        public void AccceptData()  //får bli fler funktioner samt egenskaper för dessa eller om egenskaperna går direkt ner i kartan??
        {

        }

        //2D-array + ev utskrift och än ner ev ned interfajs??
        public void RenderMap()  //Får indata till dess parametrar....eller nog bättre ta det i konstruktorn pga skapa kartan måste ju vara det absoliut viktigaste och första man gör, eller?
        {



            //const int ROWS = 10;
            //const int COLUMNS = 20;

            //char[,] theMap = new char[COLUMNS, ROWS];

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    if (row == 0 || row == 9 || column == 0 || column == 19)
                    {
                        theMap[column, row] = WallSign;
                    }
                    else if(
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
                        theMap[column, row] = WallSign;
                            }
                    



                    else if (row == 5 && column == 9 || row == 4 && column == 15 )
                    {
                        theMap[column, row] = DoorSign;

                    }
                    else if (row == 4 && column == 5 || row == 1 && column == 8)
                    {
                        theMap[column, row] = RoomWithKeySign;
                    }

                    else if(row == 7 && column == 17 || row == 4 && column == 8 || row == 8 && column == 3)
                    {
                        theMap[column, row] = MonsterSign;
                    }
                    else if( row == 2 && column == 18)
                    {
                        theMap[column, row] = ExitSign;
                    }
                    else
                    {
                        theMap[column, row] = FloorSign;
                    }

                }
            }




        }



        public void UpdateMap()   //Uppdaterar vid varje enstaka sak som händer så en ny karta ritas ut och stop-motion animering sker. tar emot anrop från subklasserna i hierarkins implementering av interfacet
        {
            bool GameOn = true; 
            while (GameOn == true)
            {

                //int row;
                //int column;

                //int playerX = PlayerXStartValue;
                //int playerY = PlayerYStartValue;



                //const int ROWS = 10;
                //const int COLUMNS = 20;

                //char[,] theMap = new char[COLUMNS, ROWS];




                //    string buffer = "";
                //for (row = 0; row < ROWS; row++)
                //{
                //    string line = "";
                //    for (column = 0; column < COLUMNS; column++)
                //    {
                //        if (column == playerX && row == playerY)
                //            line += PlayerSign;
                //        else
                //            line += theMap[column, row];
                //    }
                //    buffer += line + "\n";
                //}
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                
                int rows = theMap.GetLength(0);
                int cols = theMap.GetLength(1);
                for (int jj = 0; jj < cols; jj++)
                {
                    for (int ii = 0; ii < rows; ii++)
                    {
                        if (ii == playerX && jj == playerY)
                        {
                            Console.Write(PlayerSign);
                        }
                        else if (jj == playerY && ii == playerX || jj == playerY - 1 && ii == playerX || jj == playerY + 1 && ii == playerX ||
                            jj == playerY && ii == playerX - 1 || jj == playerY && ii == playerX + 1 || jj == playerY - 1 && ii == playerX - 1 ||
                            jj == playerY - 1 && ii == playerX + 1 || jj == playerY + 1 && ii == playerX - 1 || jj == playerY + 1 && ii == playerX + 1 ||
                            ii == rows - 1 || ii == 0 || jj == cols - 1 || jj == 0)
                        {
                            Console.Write(theMap[ii, jj]);
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
                    if (theMap[playerx, playery] == r.RoomSign)
                    {
                        c.AddKeys();                        
                        theMap[playerx, playery] = FloorSign;
                        return true;
                        
                    }
                    else if (theMap[playerx, playery] == WallSign)
                    {
                        c.AnnounceMoves();
                        return false;
                    }

                    else if (theMap[playerx, playery] == ExitSign)
                    {
                        GameOn = false;
                        GamoOver();
                        c.setCursor(4, 1);
                        Console.Write($"You did it!");
                        
                        return true;
                    }
                    else if (theMap[playerx, playery] == DoorSign)
                    {
                        if (c.HasKey())
                        {
                            c.RemoveKeys();
                            theMap[playerx, playery] = FloorSign;
                            return true;
                        }
                        
                        else
                        {
                            c.AnnounceMoves();
                            c.setCursor(1,11);
                            Console.WriteLine($"Blimey! You don't have a key... Find one.");
                            return false;
                        }
                       
                    }

                    else if (theMap[playerx, playery] == MonsterSign)
                    {
                        theMap[playerx, playery] = FloorSign;
                        c.MonsterTakesPoints();
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                    
                }

                
                //Console.Write($"{buffer}");

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                Console.WriteLine(pressedKey.Key.ToString());
                Console.Clear();
                if (pressedKey.Key.ToString() == "A")
                {
                    if (playerX != 1 && CanPass(playerX - 1, playerY))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        playerX--;
                    }
                }
                else if (pressedKey.Key.ToString() == "S")
                {
                    if (playerY != ROWS - 2 && CanPass(playerX, playerY + 1))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        playerY++;
                    }
                }
                else if (pressedKey.Key.ToString() == "D")
                {
                    if (playerX != COLUMNS - 2 && CanPass(playerX + 1, playerY))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        playerX++;
                    }
                }
                else if (pressedKey.Key.ToString() == "W")
                {
                    if (playerY != 1 && CanPass(playerX, playerY - 1))
                    {
                        c.AddMoves();
                        c.AnnounceMoves();
                        playerY--;
                    }
                }


            }

        }

        public void GamoOver()
        {
            Wall wall = new Wall();
            FetchWallSign();

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    Console.Write($"{WallSign}"); 
                }
                Console.WriteLine();

            }
            Console.WriteLine($"\n(Press any key to end.)");
           
        }
        //***************************************************************************
        //*
        //* fog of war = funktoner, egenskaper för det.  YES PLZZZZZZZZZZZZZ!!!
        //*
        //****************************************************************************



        public Map()
        {
            //initiering av tecknen för kartan vid instasiering av objekt
            FetchWallSign();
            FetchFloorSign();
            FetchPlayerSign();
            FetchDoorSign();
            FetchExitSign();
            FetchMonsterSign();
            FetchRoomWithKeySign();

        }


    }







}

