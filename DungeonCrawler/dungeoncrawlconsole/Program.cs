using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeoncrawlconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Game has Started...");
            
            DungeonCrawlMain.DungeronCrawlMain main = new DungeonCrawlMain.DungeronCrawlMain();
            ConsoleResponder responder = new ConsoleResponder();

            main.Run(responder);

            Console.WriteLine("Console game has ended");
            Console.ReadKey();
        }
    }
}
