using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeLib
{
    public class Wall : MazeElement
    {
        public override Room Enter(Player player)
        {
            throw new Exception("You just ran into a wall. Have you been drinking?");
        }
    }
}
