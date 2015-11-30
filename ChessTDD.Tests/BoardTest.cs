using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class BoardTest
    {
        private Pawn Piece { get; set; }
        private Board Target { get; set; }

        [SetUp]
        public void SetUp()
        {
            Piece = new Pawn();
            Target = new Board();
        }

        [TestFixture]
        public class GetPiece : BoardTest
        {
            [Test]
            public void retrieves_piece_added_to_location()
            {
                Target.AddPiece(Piece, new BoardCoordinate(1,1));

                Assert.AreEqual(Piece, Target.GetPiece(new BoardCoordinate(1,1)));
            }
        }

        [TestFixture]
        public class AddPiece : BoardTest
        {
            [Test]
            public void does_not_throw_exception_when_adding_a_piece_to_an_unoccupied_square()
            {
                Target.AddPiece(new Pawn(), new BoardCoordinate(2,1));
            }

            [Test]
            public void throws_exception_when_boardcoordinate_has_larger_x_value_than_board_size()
            {
                var coordinate = new BoardCoordinate(9, 1);
                Assert.Throws<ArgumentException>(() => Target.AddPiece(new Pawn(), coordinate));
            }

            [Test]
            public void throws_exception_when_boardcoordinate_has_larger_y_value_than_board_size()
            {
                var coordinate = new BoardCoordinate(1, 9);
                Assert.Throws<ArgumentException>(() => Target.AddPiece(new Pawn(), coordinate));
            }

            [Test]
            public void throws_exception_when_boardcoordinate_has_zero_x_value()
            {
                var coordinate = new BoardCoordinate(0, 1);
                Assert.Throws<ArgumentException>(() => Target.AddPiece(new Pawn(), coordinate));
            }
        }
    }
}