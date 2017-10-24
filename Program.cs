using System;

namespace Labb4_enLitenUpdate
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Highscore: 
            * 1. Jeppe - 64 moves. 1850 points.
            * 2. Silvija - 122 moves, 575 points.
            * 3. Markus - 100 moves, 300 points.
            * 4. 
            * 
            * 
            * */
            //Skapande av kartklass inklusive initering av tecknen i kartan
            Map m = new Map();
            


            //Initiering av karta
            m.RenderMap();

            //Utskrift av karta
            m.UpdateMap();

            Console.ReadKey();
        }

    } //class Program ends here
}  //EOF
