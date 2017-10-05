using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class Floor : Square, IMakeSignSendable
    {
        //Egenskaper 
        private char floorSign;
        public char FloorSign
        {
            get { return floorSign; }
            set { floorSign = value; }
        }

        //Funktioner?

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = FloorSign;
            return send;
        }

        public Floor() //Konstruktor, vilka parametrar till den??
        {
            FloorSign = (char)Signs.s5;
        }
    }
}
