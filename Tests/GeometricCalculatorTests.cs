namespace Tests
{
    public class GeometricCalculatorTests
    {
        [Fact]
        public void GetSquareMustReturnCorrectSquareOfRectangle()
        {
            //Arrange
            var rect = new Rectangle(5, 10);
            var square = rect.LongSide * rect.ShortSide;

            //Action
            var actual = new GeometricCalculator().GetSquare(rect);

            //Assert
            Assert.Equal(square, actual);
        }
    }
}