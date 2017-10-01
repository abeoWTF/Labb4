using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Exit : Square, ISendToMap
    {

        //Egenskaper ?

        private const char exitSign = (char)Signs.s7;
        public char ExitSign
        {
            get { return exitSign; }
            //set { floorSign = value; }
        }

        //Funktioner?

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = ExitSign;
            return send;
        }

        public Exit()  //Konstruktor, vilka parametrar till den??
        { }

    }




}
