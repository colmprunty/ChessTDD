using System.Linq;
using NUnit.Framework;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class PawnTest
    {
        private Pawn Target { get; set; }

        [SetUp]
        public void SetUp()
        {
            Target = new Pawn();
        }

        [TestFixture]
        public class GetMovesFrom : PawnTest
        {
            [Test]
            public void returns_2_3_as_one_result_when_passed_2_2()
            {
                var possibleMoves = Target.GetMovesFrom(new BoardCoordinate(2,2), 8);
                
                Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 3 ));
            }

            [Test]
            public void returns_2_4_as_one_result_when_passed_2_2_when_piece_has_not_moved()
            {
                var possibleMoves = Target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

                Assert.IsTrue(possibleMoves.Any(x => x.X == 2 && x.Y == 4));
            }

            [Test]
            public void does_not_return_2_4_when_passed_2_2_if_piece_has_already_moved()
            {
                Target.HasMoved = true;
                var possibleMoves = Target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

                Assert.IsFalse(possibleMoves.Any(x => x.X == 2 && x.Y == 4));
            }
        }
    }
}