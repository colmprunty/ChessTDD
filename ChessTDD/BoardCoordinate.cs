namespace ChessTDD
{
    public struct BoardCoordinate
    {
        private readonly int _x;
        private readonly int _y;

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        
        public BoardCoordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public bool IsCoordinateValidForBoardSize(int boardSize)
        {
            return IsDimensionValidForBoardSize(X, boardSize) && IsDimensionValidForBoardSize(Y, boardSize);
        }

        private bool IsDimensionValidForBoardSize(int dimension, int boardSize)
        {
            return dimension > 0 && dimension <= boardSize;
        }
    }
}