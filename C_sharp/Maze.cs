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
            finish = new Finish();
            maze = new Tile[length,width];

            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j< width; j++)
                {
                    maze[i, j] = new Tile(true);
                }   
            }

            directions.Add(new DirectionUp(this));
            directions.Add(new DirectionRight(this,mazeWidth));
            directions.Add(new DirectionDown(this, mazeHeight));
            directions.Add(new DirectionLeft(this));

            MazeCreation(1, 1);

        }

        public void MazeCreation(int x, int y)
        {

            actX = x;
            actY = y;
            DepthFirst(actX, actY);
            SetFinish();
            DrawMaze();

        }
        void SetFinish()
        {

            for (int i = 0; i < mazeHeight; i++)
            {
                for (int j = 0; j < mazeWidth; j++)
                {
                    if (!(maze[i,j].IsWall()) && (SearchForWalls(i, j) == 3))
                    {

                        actX = i;
                        actY = j;
                    }
                }
            }
            maze[actX,actY] = finish;
            finish.SetCoordinates(actX, actY);

        }

        int SearchForWalls(int i, int j)
        {

            int counter = 0;

            if (maze[i + 1,j].IsWall()) counter++;
            if (maze[i - 1,j].IsWall()) counter++;
            if (maze[i,j + 1].IsWall()) counter++;
            if (maze[i,j - 1].IsWall()) counter++;

            return counter;
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
            Random random = new Random(); //na toto daj pozor
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
        void DrawMaze()
        {
           
            for(int i = 0; i < mazeHeight; i++)
            {
                for(int j = 0; j < mazeWidth; j++)
                {
                    if ((i == 1) && (j == 1)) { 
                        drawPlayer();
                        continue;
                    }
                    Console.Write(maze[i,j].GetLook());
                }
                Console.Write("\n");
            }
        }
        void drawPlayer()
        {
            Console.Write("0");
        }

    }
}
