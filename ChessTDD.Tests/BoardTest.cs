using NUnit.Framework;

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

                Assert.AreEqual(Piece, Target.GetPiece(1,1));
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
        }
    }
}