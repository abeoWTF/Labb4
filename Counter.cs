using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
{
    public class Counter: ISendToMap
    {

        //Egenskaper:
        private static int keyAmount = 1;
        private static int movesAmount = 0;
        private int points = 0;
        
        public int KeyAmount { get=> keyAmount; set => keyAmount = value; }

        //Funktioner:

        //ökar och minskar värdet för varje motsvarande egenskap (ovan)
        public void KeyControl()
        { }


        public static bool KeyExist()
        {
            if (keyAmount > 0)
            {
                return true;
            }
            else return false;
        }

        public static void RemoveKey()
        {
            keyAmount--;
        }

        public static void MovesControl()
        {
            movesAmount++;
        }

        public static void MovesAnnouncer()
        {
            Console.WriteLine($"You have moved {movesAmount} times.");
        }

        public void pointsControl()
        { }

        public Counter()  //Konstruktor, vilka parametrar till den??
        { }

        public void SendSign()  //Skicka tecken till Map-klassen
        {
            
        }
    }
}
