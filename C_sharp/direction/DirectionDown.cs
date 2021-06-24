using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class DirectionDown : Direction
    {
        private int mazeHeight;
        public DirectionDown(Maze maze, int mazeHeight) : base(maze)
        {
            this.mazeHeight = mazeHeight;
        }

        public override void move(int actX, int actY)
        {
            if ((actX + 2 < mazeHeight - 1) && (maze.GetSquare(actX + 2, actY).IsWall()))
            {
                maze.SetSquare(actX + 2, actY, false);
                maze.SetSquare(actX + 1, actY, false);
                maze.DepthFirst(actX + 2, actY);
            }
        }
    }
}
