using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class Floor : Square, IMakeSignSendable
    {
        //ritar golv
        public Floor()
        {
            Tile = (char)Signs.s5;
        }
        public void Print()
        {
            Console.Write(Tile);
        }
        
    }
}
