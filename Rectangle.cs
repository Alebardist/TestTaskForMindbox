namespace TestTaskForMindbox
{
    public class Rectangle : Figure
    {
        public float LongSide { get; set; }
        public float ShortSide { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(float longSide, float shortSide)
        {
            LongSide = longSide;
            ShortSide = shortSide;
        }

        public override float CalculateSquare()
        {
            return ShortSide * LongSide;
        }
    }
}