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

        public Door()
        {
            Tile = (char)Signs.s2;
        }
        public void Print()
        {
            Console.Write(Tile);
        }

        //kolla om nyckel finns
        protected void CheckKey()
        {
            if (Keys.KeyExist())
                DoorOpen = true;
            Counter c = new Counter();
            c.RemoveKeys();
        }

    }
}
