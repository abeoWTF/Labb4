using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{

    public class Player : Square, IMakeSignSendable
    {
        public Player()
        {
            Tile = (char)Signs.s8;
        }
        public void Print()
        {
            Console.Write(Tile);
        }
        //private char playerSign;
        //public char PlayerSign { get { return playerSign; } set { playerSign = value; } }

        //public Player() 
        //{
        //    PlayerSign = '@';  //Spelar-tecken till map-klassen
        //}
    }
}
