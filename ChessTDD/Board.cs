using System;

namespace ChessTDD
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly Pawn[,] _pieces = new Pawn[BoardSize, BoardSize];

        public void AddPiece(Pawn piece, BoardCoordinate moveTarget)
        {
            if(!moveTarget.IsCoordinateValidForBoardSize(BoardSize))
                throw new ArgumentException("moveTarget");

            _pieces[moveTarget.X, moveTarget.Y] = piece;
        }

        public Pawn GetPiece(BoardCoordinate squareInQuestion)
        {
            return _pieces[squareInQuestion.X, squareInQuestion.Y];
        }
    }
}