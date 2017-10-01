using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Counter
    {
        //Egenskaper:
        private static int keyAmount = 0;
        private static int movesAmount = 0;
        private static int points = 0;

        public int KeyAmount{ get => keyAmount; set => keyAmount = value; }
        public int MovesAmount { get => movesAmount; set => movesAmount = value; }
        public int Points { get => points; set => points = value; }


        //Funktioner:

        //ökar och minskar värdet för varje motsvarande egenskap (ovan)
        public static int AddKeys()
        {
            return keyAmount++;
        }
        public static int RemoveKeys()
        {
            return keyAmount--;
        }

        public static int AddMoves()
        {
            return movesAmount++;
        }

        public static int pointsControl()
        {
            return points++;
        }

        public static int AnnounceMoves()
        {
            return movesAmount;
        }

        public static bool HasKey()
        {
            if (keyAmount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Counter()  //Konstruktor, vilka parametrar till den??
        { }

    }





}
