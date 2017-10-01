using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
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

        public void SendSign()  //Skicka tecken till Map-klassen
        {
            Console.WriteLine(ExitSign);
        }

        public Exit()  //Konstruktor, vilka parametrar till den??
        { }

    }
}
