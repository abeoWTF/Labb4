using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Floor f = new Floor();
            Wall w = new Wall();
            Map m = new Map();
            Player p = new Player();
            Door d = new Door();
            Counter c = new Counter();
            Keys k = new Keys();
            
            
            m.wallSign = w.WallSign;
            m.floorSign = f.FloorSign; 
            m.playerSign = p.playerSign;
            m.doorSign = d.DoorSign;
            
            
            
            

            m.TheMap();
            
            




            Console.ReadKey();


        }

    } //class Program ends here
}
