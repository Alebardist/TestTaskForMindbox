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

        [Fact]
        public void GetSquareMustReturnCorrectSquareOfTriangle()
        {
            //Arrange
            var triangle = new Triangle(5, 10, 2);
            var square = (triangle.FirstSide * triangle.ThirdSide * triangle.SecondSide) / 2;

            //Action
            var actual = new GeometricCalculator().GetSquare(triangle);

            //Assert
            Assert.Equal(square, actual);
        }

        [Fact]
        public void RectagleConstructorMustThrowExWhenArgumentsAreNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Rectangle rect = new Rectangle(-4, -4);
            });
        }
    }
}