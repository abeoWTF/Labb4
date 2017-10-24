using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public class Monster : Square, IMakeSignSendable
    {
        public Monster()
        {
            Tile = (char)Signs.s3;
        }
        public void Print()
        {
            Console.Write(Tile);
        }

        //private char monsterSign;
        //public char MonsterSign
        //{
        //    get { return monsterSign; }
        //    set { monsterSign = value; }
        //}

        //public char SendSign()  //Skicka tecken till Map-klassen
        //{
        //    char send = MonsterSign;
        //    return send;

        //}

        //public Monster()
        //{
        //    MonsterSign = (char)Signs.s3;
        //}
    }
}
