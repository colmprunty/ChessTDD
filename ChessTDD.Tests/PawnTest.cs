using System;
using NUnit.Framework;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class PawnTest
    {
        [TestFixture]
        public class GetMovesFrom
        {
            [Test]
            public void returns_2_3_when_passed_2_2()
            {
                var pawn = new Pawn();

                Tuple<int, int> possibleMoves = pawn.GetMovesFrom(2, 2);

                Assert.AreEqual(2, possibleMoves.Item1);
                Assert.AreEqual(3, possibleMoves.Item2);
            }
        }
    }
}
