using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Keys
    {
        //Egenskaper ?

        public static bool keyExist()
        {
            if (Counter.HasKey())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Funktioner?

        public Keys()  //Konstruktor, vilka parametrar till den??
        { }
    }
}
