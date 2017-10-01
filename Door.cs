using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
{
    public class Door : Square, ISendToMap
    {

        //Egenskaper 
        static bool doorOpen = false;

        private const char doorSign = (char)Signs.s2;
        public char DoorSign
        {
            get { return doorSign; }
            //set { floorSign = value; }
        }


        //Funktioner?

        Keys k = new Keys();

        public static void CheckKey()
        {
            if (Counter.KeyExist())
            {
                doorOpen = true;
                Counter.RemoveKey();
            }
        }


        public void SendSign()  //Skicka tecken till Map-klassen
        {
            Console.WriteLine(DoorSign);
        }

        public Door()  //Konstruktor, vilka parametrar till den??
        { }

    }
}
