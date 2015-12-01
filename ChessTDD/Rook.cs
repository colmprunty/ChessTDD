using System.Collections.Generic;
using System.Linq;

namespace ChessTDD
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(int xCoordinate, int yCoordinate)
        {
            return Enumerable.Empty<BoardCoordinate>();
        }
    }
}