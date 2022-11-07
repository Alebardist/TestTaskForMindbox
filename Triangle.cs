namespace TestTaskForMindbox
{
    public class Triangle : Figure
    {
        private float _firstSide;
        private float _secondSide;
        private float _thirdSide;

        public Triangle(float firstSide, float secondSide, float thirdSide)
        {
            if (HaveArgumentsWithNegativeValue(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentOutOfRangeException("Some of arguments were zero or less");
            }
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public float FirstSide
        {
            get { return _firstSide; }
        }

        public float SecondSide
        {
            get { return _secondSide; }
        }

        public float ThirdSide
        {
            get { return _thirdSide; }
        }

        /// <summary>
        /// Checks if Triangle is Rectangular by Pifagor's theoreme
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                return (FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide) ||
                    (FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide) ||
                    (ThirdSide * ThirdSide + SecondSide * SecondSide == FirstSide * FirstSide);
            }
        }

        public override float CalculateSquare()
        {
            float square = 0;

            if (IsRectangular)
            {
                square = (FirstSide * SecondSide) / 2; //Division by 2, because of formulae S = 0.5*(a*b)
            }

            return (FirstSide * SecondSide * ThirdSide) / 2; //Division by 2, because of formulae S = 0.5*(a*b*c)
        }
    }
}