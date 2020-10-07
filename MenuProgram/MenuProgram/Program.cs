using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MenuProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("FancyMenu");
            menu.Add(new MenuItem("Punkt1", "Nice mester"));
            menu.Add(new MenuItem("Punkt2", "Det er skidt"));
            Menu underMenu = new Menu("undermenu",
            new MenuItem("testpunkt", "text1"),
            new MenuItem("testpunkt2", "text2")
            );
            menu.Add(underMenu);
            menu.Add(new InfiniteMenu());
            menu.Add(new FileSystemMenu("Browse my C-Drive", new DirectoryInfo("C:\\")));
            menu.Add(new RSSMenu("Dota 2 News", "https://blog.dota2.com/feed/"));
            menu.Add(new RSSMenu("DR Nyheder", "https://www.dr.dk/nyheder/service/feeds/allenyheder"));
            menu.Start();

        }
    }

}
