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
        private int points = 3000;
        private bool superKey;

        public int KeyAmount { get => keyAmount; set => keyAmount = value; }
        public int MovesAmount { get => movesAmount; set => movesAmount = value; }
        public int Points { get => points; set => points = value; }
        public bool SuperKey { get => superKey; set => superKey = value; }
        
        //Funktioner:

        //ökar och minskar värdet för varje motsvarande egenskap (ovan)
        public void AddKeys()
        {
            Console.CursorTop = 3;
            Console.CursorLeft = 22;
            KeyAmount += 1;
            if (keyAmount > 1)
                Console.WriteLine($"You found a key! You have {KeyAmount} keys.\n");            
            else
                Console.WriteLine($"You found a key! You have {KeyAmount} key.\n");

        }

        //public void KeysAnnounce()
        //{
        //    Console.WriteLine($"You have {KeyAmount} keys.");
        //}

        public void RemoveKeys()
        {
            Console.CursorTop = 3;
            Console.CursorLeft = 22;
            KeyAmount -= 1;
            if (keyAmount > 0)
                Console.WriteLine($"You have used a key! You have {KeyAmount} key.\n");
            else
                Console.WriteLine($"You have used a key! You have {KeyAmount} keys.\n");
        }

        public int AddMoves()
        {
            return movesAmount++;
        }

        //Poängräkning - klarar man av spelet på få moves får man mer poäng.
        public void  pointsControl()
        {
            if (MovesAmount > 30)
            {
                Points -= 25;
            }
            else if (MovesAmount > 40)
            {
                Points -= 50;
            }
        }

        public void MonsterTakesPoints()
        {
            setCursor(22, 4);
            Console.WriteLine($"A monster-battle!");
            setCursor(22, 5);
            Console.WriteLine($"You've won the battle but it costed time (-300 points)");
            
            
            Points -= 300;
        }

        public void AnnounceMoves()
        {
            AmountOfKeys();
            AmountofPoints();
            pointsControl();
            setCursor(1, 13);
            Console.WriteLine($"Moves: {MovesAmount}");
            
        }

        public void AmountOfKeys()
        {
            setCursor(12, 13);
            Console.WriteLine($"Keys: {KeyAmount}");

        }
        public void AmountofPoints()
        {
            setCursor(23, 13);
            Console.WriteLine($"Points: {Points}");

        }

        public bool HasKey()
        {
            if (KeyAmount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Bestämma vart texten skrivs ut.
        public void setCursor(int left, int top)
        {
            Console.CursorLeft = left;
            Console.CursorTop = top;
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
