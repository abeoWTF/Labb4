using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Counter
    {
        //Egenskaper:
        private int keyAmount = 0;
        private int movesAmount = 0;
        private int points = 0;
        private bool superKey;

        public int KeyAmount { get => keyAmount; set => keyAmount = value; }
        public int MovesAmount { get => movesAmount; set => movesAmount = value; }
        public int Points { get => points; set => points = value; }
        public bool SuperKey { get => superKey; set => superKey = value; }
        
        //Funktioner:

        //ökar och minskar värdet för varje motsvarande egenskap (ovan)
        public int AddKeys()
        {
            Console.WriteLine($"{++keyAmount}");
            return keyAmount++;
        }

        public void KeysAnnounce()
        {
            Console.WriteLine($"You have {KeyAmount} keys.");
        }

        public int RemoveKeys()
        {
            return keyAmount--;
        }

        public int AddMoves()
        {
            return movesAmount++;
        }

        //Poängräkning - klarar man av spelet på få moves får man mer poäng.
        public int pointsControl()
        {
            if (MovesAmount < 20)
            {
                return Points += 1000;
            }
            else if (MovesAmount < 30)
            {
                return Points += 500;
            }
            else
                return 250;
        }

        public int MonsterTakesPoints()
        {
            return Points -= 200;
        }

        public int AnnounceMoves()
        {
            Console.WriteLine($"You have used {MovesAmount} moves.");
            return movesAmount;
        }

        public bool HasKey()
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

        // Om vi ska använda oss av superkeys? (t.ex. "Has superkey?".)

        public Counter(bool superKey)
        {
            this.superKey = SuperKey;
        }

    }





}
