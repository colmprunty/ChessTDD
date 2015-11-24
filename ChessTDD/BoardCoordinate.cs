namespace ChessTDD
{
    public struct BoardCoordinate
    {
        private int _x;
        private int _y;

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        
        public BoardCoordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}