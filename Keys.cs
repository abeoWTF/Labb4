using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{

    public class Keys
    {
        //kollar om nyckel finns
        public static bool KeyExist()
        {
            Counter c = new Counter();

            if (c.HasKey())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Keys()  
        { }
    }
}
