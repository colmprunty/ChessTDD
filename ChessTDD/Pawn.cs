using System.Collections.Generic;

namespace ChessTDD
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; set; }

        public override IEnumerable<BoardCoordinate> GetMovesFrom(int xCoordinate, int yCoordinate)
        {
            yield return new BoardCoordinate(xCoordinate, yCoordinate+1);

            if(!HasMoved)
                yield return new BoardCoordinate(2, 4);
        }
    }
}