using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Tile
    {

        private bool wall;

        public Tile(bool wall)
        {
            this.wall = wall;
        }

        public bool IsWall() { return wall; }
        public void SetWall(bool wall) { this.wall = wall; }
        public virtual char SetLook()
        {
            if (this.wall) return '■';
            else return ' ';
        }
        public virtual void Action()
        {
        }
    }
}
