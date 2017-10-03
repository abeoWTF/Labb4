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
        private int playerX=3;
        private int playerY=3;

       

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
        public void FetchDoorSign(){ Door d = new Door(); DoorSign = d.SendSign(); }
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
                    if (row == 0 || row == ROWS - 1 || column == 0 || column == COLUMNS - 1)
                    {
                        theMap[column, row] = WallSign;
                    }
                    else if (true)
                        for (int i = 4; i <= 4; i++)
                        {
                            for (column = 9; column <= 18; column++)
                            {
                                theMap[column, row] = WallSign;
                            }
                        }

                    

                    else if (row == 5 && column == 9 || row == 4 && column == 15)
                    {
                        theMap[column, row] = DoorSign;

                    }
                    else if (row == 4 && column == 5)
                    {
                        theMap[column, row] = RoomWithKeySign;
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


            while (true)
            {
                
                int row;
                int column;

                //int playerX = PlayerXStartValue;
                //int playerY = PlayerYStartValue;



                //const int ROWS = 10;
                //const int COLUMNS = 20;

                //char[,] theMap = new char[COLUMNS, ROWS];

                string buffer = "";
                for (row = 0; row < ROWS; row++)
                {
                    string line = "";
                    for (column = 0; column < COLUMNS; column++)
                    {
                        if (column == playerX && row == playerY)
                            line += PlayerSign;
                        else
                            line += theMap[column, row];
                    }
                    buffer += line + "\n";
                }

                bool CanPass(int playerx, int playery)
                {
                    if (theMap[playerx, playery] == WallSign)
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

