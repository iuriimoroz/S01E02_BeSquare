using Microsoft.VisualStudio.TestTools.UnitTesting;
using S01E02_BeSquare;

namespace Tests
{
    [TestClass]
    public sealed class RectangleTests
    {
        [DataTestMethod]
        [DataRow(10, 10, true)]
        [DataRow(10, 1, false)]
        [DataRow(1, 1, true)]
        [DataRow(int.MaxValue, int.MaxValue, true)]
        public void IsSquare_Matches_SquarenessOfRectangle(int width, int height, bool shouldBeSquare)
        {
            var rectangle = new Rectangle(width, height);

            Assert.AreEqual(shouldBeSquare, rectangle.IsSquare);
        }
    }
}
