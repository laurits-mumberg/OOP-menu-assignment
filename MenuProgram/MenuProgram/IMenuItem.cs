namespace MenuProgram
{
    public interface IMenuItem
    {
        string Title { get; set; }

        IMenuItem PrevMenuItem { get; set; }
        void Select();

    }
}
