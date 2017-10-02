using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Door : Square, ISendToMap
    {

        //Egenskaper 
        private static bool doorOpen;
        public static bool DoorOpen{ get => doorOpen; set => doorOpen = value; }
        
        private const char doorSign = (char)Signs.s2;
        public static char DoorSign
        {
            get { return doorSign; }
            //set { doorSign = value; }
        }

        //Funktioner?

        Keys k = new Keys();

        public static bool CheckKey(char sign)
        {
            if (Keys.keyExist())
            {
                DoorOpen = true;
                Counter.RemoveKeys();
                DoorOpened(DoorSign);
                return true;
            } 
            else
            {
                Console.Clear();
                Console.CursorTop = 11;
                Console.WriteLine($"You have no keys.");
                DoorOpen = false;
                return false;
            }
        }

        public static void DoorOpened(char sign)
        {
            if(DoorOpen)
            {
                sign = Floor.FloorSign;
            }
        }

        public char SendSign()  //Skicka tecken till Map-klassen
        {
            char send = DoorSign;
            return send;
        }

        public Door()  //Konstruktor, vilka parametrar till den??
        { }

        

    }
}
