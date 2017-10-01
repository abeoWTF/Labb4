using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
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

        public void SendSign()  //Skicka tecken till Map-klassen
        {
            Console.WriteLine(MonsterSign);
        }

        public Monster()
        {

        }


    }
}
