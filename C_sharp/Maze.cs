using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Maze
    {

        private Tile[,] maze;
        private int actX;
        private int actY;
        private int mazeWidth;
        private int mazeHeight;
        private List<Direction> directions = new List<Direction>();
        private Finish finish;

        public Maze(int length, int width)
        {
            mazeWidth = width;
            mazeHeight = length;
            finish = new Finish(this);
            maze = new Tile[length,width];

            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j< width; j++)
                {
                    maze[i, j] = new Tile(true);
                }   
            }

            directions.Add(new DirectionUp(this));
           
        }

        public void DepthFirst(int actX, int actY)
        {

            int[] directions = GenerateRandomDirections();

            foreach (int i in directions)
            {
                this.directions[i].move(actX, actY); 
            }

        }

        public int[] GenerateRandomDirections()
        {

            int[] arr = { 0,1,2,3 };
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            return arr;

        }


        public void SetSquare(int x, int y, bool wall)
        {
            this.maze[x,y].SetWall(wall);
        }
        public Tile GetSquare(int x, int y)
        {
            return maze[x,y];
        }

    }
}
