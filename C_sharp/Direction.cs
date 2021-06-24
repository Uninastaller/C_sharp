using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    abstract class Direction
    {

        protected Maze maze;

        protected Direction(Maze maze)
        {
            this.maze = maze;
        }

        public abstract void move(int actX, int actY);
    }
}
