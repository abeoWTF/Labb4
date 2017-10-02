using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{


    public class Monster : Square, ISendToMap
    {
        //Egenskaper
        private const char monsterSign = (char)Signs.s3;
        public char MonsterSign
        {
            get { return monsterSign; }
            //set { floorSign = value; }
        }

        //Funktioner?

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = MonsterSign;
            return send;

        }

        public Monster()
        {

        }
    }
}
