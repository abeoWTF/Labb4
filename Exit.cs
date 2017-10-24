using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{

    public class Exit : Square, IMakeSignSendable
    {
        public Exit()
        {
            Tile = (char)Signs.s7;
        }
        public void Print()
        {
            Console.Write(Tile);
        }
        //private char exitSign;
        //public char ExitSign
        //{
        //    get { return exitSign; }
        //    set { exitSign = value; }
        //}

        //public char SendSign()  //Skicka tecken till Map-klassen
        //{
        //    char send = ExitSign;
        //    return send;
        //}

        //public Exit()  
        //{
        //    ExitSign = (char)Signs.s7;

        //}

    }
}
