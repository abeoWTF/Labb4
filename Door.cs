using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{

    public class Door : Square, IMakeSignSendable
    {
        private bool doorOpen;
        public bool DoorOpen
        {
            get { return doorOpen; }
            set { doorOpen = value; }
        }

        private char doorSign;
        public char DoorSign
        {
            get { return doorSign; }
            set { doorSign = value; }
        }

        //kolla om nyckel finns
        protected void CheckKey()
        {
            if (Keys.KeyExist())
                DoorOpen = true;
            Counter c = new Counter();
            c.RemoveKeys();
        }

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = DoorSign;
            return send;
        }

        public Door()
        {
            DoorOpen = false;
            DoorSign = (char)Signs.s2;
        }

    }
}
