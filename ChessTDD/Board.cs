namespace ChessTDD
{
    public class Board
    {
        private readonly Pawn[,] _pieces = new Pawn[8,8];

        public void AddPiece(Pawn piece, int xCoordinate, int yCoordinate)
        {
            _pieces[xCoordinate, yCoordinate] = piece;
        }

        public Pawn GetPiece(int xCoordinate, int yCoordinate)
        {
            return _pieces[xCoordinate, yCoordinate];
        }
    }
}