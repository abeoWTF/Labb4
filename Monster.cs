using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class Monster : Square, IMakeSignSendable
    {
        public Monster()
        {
            Tile = (char)Signs.s3;
        }
        public void Print()
        {
            Console.Write(Tile);
        }

    }
}
