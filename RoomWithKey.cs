using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class RoomWithKey : Square, IMakeSignSendable
    {
        public RoomWithKey()
        {
            Tile = (char)Signs.s6;
        }
        public void Print()
        {
            Console.Write(Tile);
        }
      
    }
}
