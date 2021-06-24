using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Finish : Tile
    {
        private int x;
        private int y;
        private Maze maze;

        public Finish(Maze maze) : base(false)
        {
            this.maze = maze;
        }

        public void setCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
            SetWall(false);
        }

        public override char SetLook()
        {
            return '◙';
        }
        public override void Action()
        {
            maze.won();
        }

        public int GetX() { return x;}
        public int GetY() { return y;}
    }
}
