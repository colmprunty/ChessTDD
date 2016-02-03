using System.Linq;
using NUnit.Framework;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class BishopTest
    {
        private Bishop Target { get; set; }
        private const int DefaultBoardSize = 8;

        [SetUp]
        public void SetUp()
        {
            Target = new Bishop();
        }

        [TestFixture]
        public class GetMovesFrom : BishopTest
        {
            [Test]
            public void returns_non_empty_collection()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize).Any());
            }

            [Test]
            public void returns_2_2_for_1_1()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize).Any(x => x.X == 2 && x.Y == 2));
            }

            [Test]
            public void returns_1_1_for_2_2()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(2,2), DefaultBoardSize).Any(x => x.X == 1 && x.Y == 1));
            }

            [Test]
            public void returns_2_1_for_1_2()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1,2),DefaultBoardSize).Any(x => x.X == 2 && x.Y == 1));
            }

            [Test]
            public void does_not_return_negative_values_for_boardcoordinate()
            {
                Assert.IsFalse(Target.GetMovesFrom(new BoardCoordinate(1,2),DefaultBoardSize).Any(bc => bc.Y < 0 || bc.X < 0));
            }

            [Test]
            public void returns_8_8_for_1_1()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1,1), DefaultBoardSize).Any(x => x.X == 8 && x.Y == 8));
            }

            [Test]
            public void returns_8_1_for_1_8()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1,8), DefaultBoardSize).Any(x => x.X == 8 && x.Y == 1));
            }
        }
    }
}