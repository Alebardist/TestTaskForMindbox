namespace TestTaskForMindbox
{
    public class Rectangle : Figure
    {
        private float _longSide;
        private float _shortSide;

        public Rectangle(float longSide, float shortSide)
        {
            if (HaveArgumentsWithNegativeValue(longSide, shortSide))
            {
                throw new ArgumentOutOfRangeException("Some of arguments were zero or less");
            }
            _longSide = longSide;
            _shortSide = shortSide;
        }

        public float LongSide
        {
            get { return _longSide; }
        }

        public float ShortSide
        {
            get { return _shortSide; }
        }

        public override float CalculateSquare()
        {
            return ShortSide * LongSide;
        }
    }
}