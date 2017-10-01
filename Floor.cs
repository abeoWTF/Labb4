using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
{
    public class Floor : Square, ISendToMap
    {

        //Egenskaper 
        private const char floorSign = (char)Signs.s5;
        public char FloorSign
        {
            get { return floorSign; }
            //set { floorSign = value; }
        }


        //Funktioner?

        public void SendSign()  //Skicka tecken till Map-klassen
        {
            Console.WriteLine(FloorSign);
        }


        public Floor() //Konstruktor, vilka parametrar till den??
        { }


    }
}
