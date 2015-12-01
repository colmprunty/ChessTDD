using NUnit.Framework;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class BoardCoordinateTest
    {
        [TestFixture]
        public class IsCoordinateValidForBoardSize
        {
            [Test]
            public void returns_false_for_x_less_than_zero()
            {
                var coordinate = new BoardCoordinate(-1, 1);
                Assert.IsFalse(coordinate.IsCoordinateValidForBoardSize(8));
            }

            [Test]
            public void returns_false_for_y_less_than_zero()
            {
                var coordinate = new BoardCoordinate(1, -1);
                Assert.IsFalse(coordinate.IsCoordinateValidForBoardSize(8));
            }
        }
    }
}