namespace MenuProgram
{
    public class InfiniteMenu : Menu
    {
        public InfiniteMenu() : base("Infinite Menu") { }

        public override void Select()
        {
            //Adds 5 new infinite menues to this menu, only if it already has 0
            if (MenuItems.Count <= 0)
            {
                for (int i = 0; i < 6; i = i + 1)
                {
                    MenuItems.Add(new InfiniteMenu());
                }
            }
            Start();
        }
    }
}
