using System;
using System.Linq;
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
            public void returns_2_3_as_one_result_when_passed_2_2()
            {
                var pawn = new Pawn();

                var possibleMoves = pawn.GetMovesFrom(2, 2);
                
                Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 3 ));
            }
        }
    }
}
