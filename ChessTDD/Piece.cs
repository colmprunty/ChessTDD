﻿using System.Collections.Generic;

namespace ChessTDD
{
    public abstract class Piece
    {
        public abstract IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize);
    }
}