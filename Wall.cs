using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class Wall : Square, IMakeSignSendable
    {
        private char wallSign;
        public char WallSign
        {
            get { return wallSign; }
            set { wallSign = value; }
        }

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = WallSign;
            return send;
        }

        public Wall()     
        {
            WallSign = (char)Signs.s1;
        }
    }

}
