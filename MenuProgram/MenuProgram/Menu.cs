using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuProgram
{
    public class Menu : IMenuItem
    {
        public string Title { get; set; }

        public IMenuItem PrevMenuItem { get; set; }

        public List<IMenuItem> MenuItems = new List<IMenuItem>();

        private bool _running;

        private int _selectedItemIndex = 0;

        public Menu(string title, params IMenuItem[] menuItems)
        {
            Title = title;

            MenuItems = menuItems.ToList();
        }

        public virtual void Select() => Start();

        public void Add(IMenuItem itemToAdd) => MenuItems.Add(itemToAdd);

        public void Start()
        {
            _running = true;
            do
            {
                DrawMenu();
                HandleInput();
            } while (_running);

        }

        private void DrawMenu()
        {
            Console.Clear();

            for (int i = 0; i < MenuItems.Count; i++)
            {
                if(i == _selectedItemIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(MenuItems[i].Title);
                }
                else
                {
                    Console.WriteLine(MenuItems[i].Title);
                }
                Console.ResetColor();
            }
        }

        private void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace:
                    //Returns to previous IMenuItem
                    if (PrevMenuItem != null)
                    {
                        _running = false;
                        PrevMenuItem.Select();
                    }
                    break;
                case ConsoleKey.Escape:
                    _running = false;
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.Enter:
                    _running = false;
                    MenuItems[_selectedItemIndex].PrevMenuItem = this;
                    MenuItems[_selectedItemIndex].Select();
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("Laurits er en mand.");
                    break;
                default:
                    break;
            }
        }

        private void MoveUp()
        {
            if (_selectedItemIndex > 0)
            {
                _selectedItemIndex--;
            }
        }

        private void MoveDown()
        {
            if(_selectedItemIndex < MenuItems.Count - 1)
            {
                _selectedItemIndex++;
            }
        }
    }
}
