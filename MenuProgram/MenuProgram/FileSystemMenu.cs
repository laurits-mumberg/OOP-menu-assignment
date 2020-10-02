using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    class FileSystemMenu : Menu
    {
        public FileSystemMenu() : base("test")
        {

        }

        public override void Select()
        {
            //Adds 5 new infinite menues to this menu, only if it already has 0
            if (MenuItems.Count <= 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    MenuItems.Add(new InfiniteMenu());
                }
            }
            Start();
        }
    }
}
