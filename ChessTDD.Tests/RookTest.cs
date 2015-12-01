using System.Linq;
using NUnit.Framework;

namespace ChessTDD.Tests
{
    [TestFixture]
    public class RookTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void returns_empty_collection()
            {
                var rook = new Rook();
                Assert.AreEqual(rook.GetMovesFrom(1,1).Count(), 0);}
        }
    }
}