using System.Collections.Generic;
using System.Linq;

namespace ChessTDD
{
    public class Bishop : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize)
        {
            var moves = new List<BoardCoordinate>();
            for (int i = 0; i < boardSize; i++)
            {
                var upOneOverOne = new BoardCoordinate(startingLocation.X + i, startingLocation.Y + i);
                if(upOneOverOne.IsCoordinateValidForBoardSize(boardSize))
                    moves.Add(upOneOverOne);


                var downOneOverOne = new BoardCoordinate(startingLocation.X + i, startingLocation.Y - i);
                if(downOneOverOne.IsCoordinateValidForBoardSize(boardSize))
                    moves.Add(downOneOverOne);

                var upOneBackOne = new BoardCoordinate(startingLocation.X - i, startingLocation.Y + i);
                if(upOneBackOne.IsCoordinateValidForBoardSize(boardSize))
                    moves.Add(upOneBackOne);

                var backOneDownOne = new BoardCoordinate(startingLocation.X - i, startingLocation.Y - i);
                if(backOneDownOne.IsCoordinateValidForBoardSize(boardSize))
                    moves.Add(backOneDownOne);
            }

            return moves;
        }
    }
}