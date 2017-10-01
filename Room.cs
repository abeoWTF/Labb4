using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
{

    public class Room : Square, ISendToMap
    {

        //Egenskaper ?
        private const char roomSign = (char)Signs.s6;
        public char RoomSign
        {
            get { return roomSign; }
            //set { floorSign = value; }
        }



        //Funktioner?

        public void SendSign()  //Skicka tecken till Map-klassen
        {
            Console.WriteLine(RoomSign);
        }

        public Room()  ////Konstruktor, vilka parametrar till den??
        { }
    }
}
