using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    class RSSMenuItem : MenuItem
    {
        private string _link;

        public RSSMenuItem(string title, string content, string link) : base(title, content)
        {
            _link = link;
        }

        public override void Select()
        {
            DrawContent();
            WaitForKeys();
        }

        private void WaitForKeys()
        {
            bool running = true;

            do
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.Backspace:
                        running = false;
                        PrevMenuItem.Select();
                        break;
                    case ConsoleKey.Enter:
                        System.Diagnostics.Process.Start(_link);
                        break;
                }
            } while (running);
        }
    }
}
