using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_enLitenUpdate
{
    public abstract class Square
    {
        //tecken till tecken-klasserna
        public enum Signs { s1 = '#', s2 = 'D', s3 = 'M', s5 = '.', s6 = 'n', s7 = 'U',s8 = '@'};

        private char tile;
        public char Tile
        {
            get { return tile; }
            set { tile = value; }
        }

        //Ritar karta.
        public void Draw()
        {
          Console.Write(Tile);
           
        }
    }
}
