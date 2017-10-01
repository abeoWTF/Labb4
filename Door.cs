using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Door : Square, ISendToMap
    {

        //Egenskaper 
        bool doorOpen = false;

        private const char doorSign = (char)Signs.s2;
        public static char DoorSign
        {
            get { return doorSign; }
            //set { floorSign = value; }
        }


        //Funktioner?

        Keys k = new Keys();


        protected void CheckKey()
        {
            if (Keys.keyExist())
                doorOpen = true;
            Counter.RemoveKeys();
        }

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = DoorSign;
            return send;

        }






        public Door()  //Konstruktor, vilka parametrar till den??
        { }

    }







}
