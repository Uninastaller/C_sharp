using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class DirectionLeft : Direction
    {

        public DirectionLeft(Maze maze) : base(maze) { }

        public override void move(int actX, int actY)
        {
            if ((actY - 2 > 0) && (maze.GetSquare(actX, actY - 2).IsWall()))
            {
                maze.SetSquare(actX, actY - 2, false);
                maze.SetSquare(actX, actY - 1, false);
                maze.DepthFirst(actX, actY - 2);
            }
        }
    }
}
