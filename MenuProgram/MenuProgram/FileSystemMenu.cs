using System;
using System.IO;
using System.Threading;

namespace MenuProgram
{
    class FileSystemMenu : Menu
    {

        private DirectoryInfo _directoryInfo;

        public FileSystemMenu(string Title, DirectoryInfo directoryInfo) : base(Title)
        {
            _directoryInfo = directoryInfo;
        }

        public override void Select()
        {
            if (MenuItems.Count <= 0)
            {
                try
                {
                    foreach (string entry in Directory.GetDirectories(_directoryInfo.FullName))
                    {
                        MenuItems.Add(new FileSystemMenu(entry, new DirectoryInfo(entry)));
                    }
                }
                catch(UnauthorizedAccessException ex)
                {
                    Console.WriteLine("Unauthorized Access\n");
                    Thread.Sleep(3000); // wait 3 seconds
                    PrevMenuItem.Select();
                }
            }
            Start();
        }
    }
}
