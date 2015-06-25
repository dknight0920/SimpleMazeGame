using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeLib
{
    public abstract class MazeElement
    {
        public abstract Room Enter(Player player);
    }
}
