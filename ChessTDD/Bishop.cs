﻿using System.Collections.Generic;
using System.Linq;

namespace ChessTDD
{
    public class Bishop : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize)
        {
            var allDistancesFromStart = Enumerable.Range(1, boardSize+1);
            var allPossibleBoardCoordinates = allDistancesFromStart.SelectMany(sp => GetRadialDiagonalFrom(startingLocation, sp));
            var legalBoardCoordinates = allPossibleBoardCoordinates.Where(bc => bc.IsCoordinateValidForBoardSize(boardSize));
            return legalBoardCoordinates;
        }

        private static IEnumerable<BoardCoordinate> GetRadialDiagonalFrom(BoardCoordinate startingPosition, int distance)
        {
            yield return new BoardCoordinate(startingPosition.X + distance, startingPosition.Y + distance);
            yield return new BoardCoordinate(startingPosition.X + distance, startingPosition.Y - distance);
            yield return new BoardCoordinate(startingPosition.X - distance, startingPosition.Y + distance);
            yield return new BoardCoordinate(startingPosition.X - distance, startingPosition.Y - distance);
        }
    }
}