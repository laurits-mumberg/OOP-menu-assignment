using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;

namespace MenuProgram
{
    class RSSMenu : Menu
    {
        private string _rssURL;
        public RSSMenu(string title, string rssURL) : base(title)
        {
            _rssURL = rssURL;
        }

        public override void Select()
        {
            //Resets the old list of MenuItems
            MenuItems.Clear();

            //Gets the feed
            XmlReader reader = XmlReader.Create(_rssURL);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                
                MenuItems.Add(new RSSMenuItem(item.Title.Text, item.Summary.Text, item.Links[0].Uri.ToString()));
            }

            Start();
        }
    }
}
