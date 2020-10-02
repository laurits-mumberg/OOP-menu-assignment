using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    public interface IMenuItem
    {
        string Title { get; set; }

        IMenuItem PrevMenuItem { get; set; }
        void Select();

    }
}
