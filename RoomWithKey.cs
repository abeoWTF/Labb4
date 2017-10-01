using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class RoomWithKey : Square, ISendToMap
    {

        //Egenskaper ?
        private const char roomSign = (char)Signs.s6;
        public static char RoomSign
        {
            get { return roomSign; }
            //set { floorSign = value; }
        }
        //Funktioner?

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = RoomSign;
            return send;
        }

        public RoomWithKey()  ////Konstruktor, vilka parametrar till den??
        { }
    }






}
