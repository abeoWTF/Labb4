using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class RoomWithKey : Square, IMakeSignSendable
    {
        private char roomSign;
        public char RoomSign
        {
            get { return roomSign; }
            set { roomSign = value; }
        }

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = RoomSign;
            return send;
        }

        public RoomWithKey()  
        {
            RoomSign = (char)Signs.s6;
        }
    }
}
