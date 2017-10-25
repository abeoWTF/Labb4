using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Labb4_enLitenUpdate
{
    class Wall : Square, IMakeSignSendable
    {
        //Vägg för mappen.

        public Wall()
        {
            Tile = (char)Signs.s1;
        }
        public void Print()
        {
            Console.Write(Tile);
        }

       
    }

}
