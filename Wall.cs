using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    public class Wall : Square, ISendToMap
    {
        //Egenskaper 

        private const char wallSign = (char)Signs.s1;
        public static char WallSign
        {
            get { return wallSign; }
            //set { floorSign = value; }
        }
        //Funktioner?

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = WallSign;
            return send;
        }
        public Wall()
        { }
    }

}
