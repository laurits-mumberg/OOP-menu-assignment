using System.IO;

namespace MenuProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("FancyMenu");
            menu.Add(new MenuItem("Punkt1", "Nice meister."));
            menu.Add(new MenuItem("Punkt2", "Det er sk*dt."));

            Menu underMenu = new Menu("undermenu",
                new MenuItem("testpunkt", "text1"),
                new MenuItem("testpunkt2", "text2")
            );

            menu.Add(underMenu);
            menu.Add(new InfiniteMenu());
            menu.Add(new InfiniteMenu());
            menu.Add(new FileSystemMenu("Browse my C-Drive", new DirectoryInfo("C:\\")));
            // TO DO Naxiel twitter
            menu.Add(new RSSMenu("Dota 2 News", "https://blog.dota2.com/feed/"));
            menu.Add(new RSSMenu("DR Nyheder", "https://www.dr.dk/nyheder/service/feeds/allenyheder"));
            menu.Add(new RSSMenu("Naxiel News", "https://rss.app/feeds/aNChsspxb2mudCK4.xml"));
            menu.Add(new SurpriseMenu());
            
            Menu Slap = new Menu("SlapCity",
                new LinkMenuItem("SlapCity 1", "", "https://krogh.itch.io/slapcity"),
                new LinkMenuItem("SlapCity 2", "", "https://krogh.itch.io/slapcity2"),
                new LinkMenuItem("SlapCity 3", "", "https://krogh.itch.io/slap-city-3")
            );
            menu.Add(Slap);

            menu.Start();
        }
    }

}
