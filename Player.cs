using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{

    public class Player
    {
        private char playerSign;
        public char PlayerSign { get { return playerSign; } set { playerSign = value; } }

        public Player() 
        {
            PlayerSign = '@';  //Spelar-tecken till map-klassen
        }
    }
}
