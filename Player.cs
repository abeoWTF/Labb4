using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Player : Square
    {
        //Egenskaper ?
        //Egenskap för tecken iom den här klassen ligger utanför hierarkin?
        private const char playerSign = (char)Signs.s4;
        public static char PlayerSign
        {
            get { return playerSign; }
            //set { floorSign = value; }
        }

        //public char playerSign = '@';

        //Funktioner?
        //"Interagera med omgivning!!!"  //EXTREMT VIKTIG SKALL DET VARA EN FUNKTION HÄR ELLER INBYGGT I KARTAN?
        //Interagera med andra rum som monster, dörrar osv!! vilket genererar funktioner, egenskaper etc

        public Player() //Konstruktor, vilka parametrar till den??
        { }
    }





}
