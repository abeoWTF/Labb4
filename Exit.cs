using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{

    public class Exit : Square, IMakeSignSendable
    {
        //Utgången
        public Exit()
        {
            Tile = (char)Signs.s7;
        }
        public void Print()
        {
            Console.Write(Tile);
        }

    }
}
