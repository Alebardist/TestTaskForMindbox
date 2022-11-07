namespace TestTaskForMindbox
{
    public class Circle : Figure
    {
        public float Radius { get; set; }

        public  float Diameter{ get; set; }

        public Circle(float radius)
        {
            if (HaveArgumentsWithNegativeValue(radius))
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }

            Radius = radius;
        }

        public override float CalculateSquare()
        {
            //HACK: need unpacking, cause PI is double type
            return (float) Math.PI * (Radius * Radius);
        }
    }
}