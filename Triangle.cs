namespace TestTaskForMindbox
{
    internal class Triangle : Figure
    {
        /// <summary>
        /// Checks if Triangle is Rectangular by Pifagor's theoreme
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                if ((FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide) ||
                    (FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide) ||
                    (ThirdSide * ThirdSide + SecondSide * SecondSide == FirstSide * FirstSide))
                    return true;
                return false;
            }
        }

        public float FirstSide { get; set; }
        public float SecondSide { get; set; }
        public float ThirdSide { get; set; }

        public override float CalculateSquare()
        {
            float square = 0;

            if (IsRectangular)
            {
                //TODO: need to pick a pair of the shortest sides
                square = (FirstSide * SecondSide) / 2; //Division by 2, because of formulae S = 0.5*(a*b)
            }

            return (FirstSide * SecondSide * ThirdSide)/2; //Division by 2, because of formulae S = 0.5*(a*b*c)
        }
    }
}