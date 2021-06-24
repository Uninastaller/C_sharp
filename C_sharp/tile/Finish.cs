using System;


namespace C_sharp
{
    class Finish : Tile
    {
        private int x;
        private int y;

        public Finish() : base(false) { }
        
       

        public void SetCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
            SetWall(false);
        }

        public override char GetLook()
        {
            return '»';
        }
        public override void Action()
        {
            throw new NotImplementedException();
        }

        public int GetX() { return x;}
        public int GetY() { return y;}
    }
}
