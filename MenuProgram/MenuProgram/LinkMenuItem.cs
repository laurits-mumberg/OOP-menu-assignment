using System;

namespace MenuProgram
{
    public class LinkMenuItem : MenuItem
    {
        private string _link;

        public LinkMenuItem(string title, string content, string link) : base(title, content)
        {
            _link = link;
        }
        public override void Select()
        {
            LinkOpen();
            DrawContent();
            
        }
        private void LinkOpen()
        {
            System.Diagnostics.Process.Start(_link);
        }
    }
}
