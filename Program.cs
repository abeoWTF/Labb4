using System;

namespace Labb4_enLitenUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
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
