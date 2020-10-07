using System.IO;

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
                foreach (string entry in Directory.GetDirectories(_directoryInfo.FullName))
                {
                    MenuItems.Add(new FileSystemMenu(entry, new DirectoryInfo(entry)));
                }
            }
            Start();
        }
    }
}
