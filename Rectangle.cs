namespace TestTaskForMindbox
{
    internal class Rectangle : Figure
    {
        public int LongSide { get; set; }
        public int ShortSide { get; set; }

        public override float CalculateSquare()
        {
            return ShortSide * LongSide;
        }
    }
}