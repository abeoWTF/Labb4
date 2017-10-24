using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Labb4_enLitenUpdate
{
    class Wall : Square, IMakeSignSendable
    {
        public Wall()
        {
            Tile = (char)Signs.s1;
        }
        public void Print()
        {
            Console.Write(Tile);
        }

        //private char wallSign = '#';
        //public char WallSign
        //{
        //    get { return wallSign; }
        //    set { wallSign = value; }
        //}

        //public char SendSign()  //Skicka tecken till Map-klassen
        //{
        //    char send = WallSign;
        //    return send;
        //}

        //public Wall()     
        //{
        //    WallSign = (char)Signs.s1;
        //}
    }

}
