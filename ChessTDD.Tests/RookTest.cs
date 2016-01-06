using System.Linq;
using NUnit.Framework;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class RookTest
    {
        private Rook Target { get; set; }
        private static readonly BoardCoordinate DefaultCoordinate = new BoardCoordinate(1, 1);
        private const int DefaultBoardSize = 8;

        [SetUp]
        public void Setup()
        {
            Target = new Rook();
        }

        [TestFixture]
        public class Constructor : RookTest
        {
            [Test]
            public void returns_7_vertical_moves_with_board_size_8()
            {
                var moves = Target.GetMovesFrom(DefaultCoordinate, DefaultBoardSize);

                Assert.AreEqual(moves.Count(x => x.X == 1), 7);
            }

            [Test]
            public void returns_7_horizontal_moves_with_board_size_8()
            {
                var moves = Target.GetMovesFrom(DefaultCoordinate, DefaultBoardSize);

                Assert.AreEqual(moves.Count(x => x.Y == 1), 7);
            }

            [Test]
            public void returns_no_moves_that_contain_a_zero()
            {
                var moves = Target.GetMovesFrom(DefaultCoordinate, DefaultBoardSize);

                Assert.AreEqual(0, moves.Count(x => x.X == 0 || x.Y == 0));
            }

            [Test]
            public void returns_7_4_from_7_1()
            {
                var moves = Target.GetMovesFrom(new BoardCoordinate(7, 1), DefaultBoardSize);

                Assert.IsTrue(moves.Any(bc => bc.X == 7 && bc.Y == 4));
            }
        }
    }
}