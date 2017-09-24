using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeoncrawlconsole
{
    class ConsoleResponder : DungeonCrawlMain.IResponder
    {
        public void ChangeBackgroundColor()
        {
            Console.WriteLine("Behold as the COlor Before you Changes to a stunnig red then its blue ");
        }
    }
}
