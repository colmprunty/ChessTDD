﻿using System.Collections.Generic;

namespace ChessTDD
{
    public class Pawn
    {
        public IEnumerable<BoardCoordinate> GetMovesFrom(int xCoordinate, int yCoordinate)
        {
            yield return new BoardCoordinate(xCoordinate, yCoordinate+1);
        } 
    }
}