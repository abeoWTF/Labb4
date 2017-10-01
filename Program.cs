using System;

namespace Labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kod för testutskrift:
            /*
            Floor f = new Floor();
            Wall w = new Wall();
            Map m = new Map();
            Player p = new Player();
            

            m.wallSign = w.WallSign;
            m.floorSign = f.FloorSign;
            m.playerSign = p.playerSign;

            m.RenderMap();
            */



            //En instans av varje förekommande klass för access

            Map m = new Map();
            Wall w = new Wall();
            Door d = new Door();
            Monster kakmonstret = new Monster();
            Floor f = new Floor();
            RoomWithKey r = new RoomWithKey();
            Exit e = new Exit();
            Counter c = new Counter();
            Keys k = new Keys();
            Player p = new Player();

            m.TheMap();

            //Initiera kart-klassen med tecken vid start av programmet

            //m.FetchWallSign();
            //m.FetchFloorSign();
            //m.FetchPlayerSign();
            //m.FetchDoorSign();
            //m.FetchExitSign();
            //m.FetchMonsterSign();
            //m.FetchRoomWithKeySign();

            ////Testutskrift av tecken:

            //char a = m.WallSign;
            //char b = m.FloorSign;
            //char cn = m.PlayerSign;
            //char dn = m.DoorSign;
            //char en = m.ExitSign;
            //char fn = m.MonsterSign;
            //char g = m.RoomWithKeySign;

            //Console.WriteLine("Tesutskrift fur alle: ");
            //Console.WriteLine("");
            //Console.WriteLine($"{a}   {b}   {cn}    {dn}    {en}    {fn}     {g}");


            Console.ReadKey();


        }

    } //class Program ends here









}  //EOF
