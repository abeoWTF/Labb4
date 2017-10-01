using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
{
    public class Wall : Square, ISendToMap
    {
        //Egenskaper 

        private const char wallSign = (char)Signs.s1;
        public char WallSign
        {
            get { return wallSign; }
            //set { floorSign = value; }
        }


        //Funktioner?

        public void SendSign()  //Skicka tecken till Map-klassen
        {
            Console.WriteLine(wallSign);
        }


        public Wall()
        { }

    }
}
