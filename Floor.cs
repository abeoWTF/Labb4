using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Floor : Square, ISendToMap
    {

        //Egenskaper 
        private const char floorSign = (char)Signs.s5;
        public static char FloorSign
        {
            get { return floorSign; }
            set { FloorSign = value; }
        }

        //Funktioner?

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = FloorSign;
            return send;
        }
                
        public Floor() //Konstruktor, vilka parametrar till den??
        { }
    }
}
