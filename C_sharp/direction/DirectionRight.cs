using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class DirectionRight : Direction
    {
        private int mazeWidth;

        public DirectionRight(Maze maze, int mazeWidth) : base(maze)
        {
            this.mazeWidth = mazeWidth;
        }

        public override void move(int actX, int actY)
        {
            if ((actY + 2 < mazeWidth - 1) && (maze.GetSquare(actX, actY + 2).IsWall()))
            {
                maze.SetSquare(actX, actY + 2, false);
                maze.SetSquare(actX, actY + 1, false);
                maze.DepthFirst(actX, actY + 2);
            }
        }
    }
}
