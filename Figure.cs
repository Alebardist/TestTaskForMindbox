using System;
namespace TestTaskForMindbox
{
    public abstract class Figure
    {
        public abstract float CalculateSquare();

        public static bool HaveArgumentsWithNegativeValue(params float[] args)
        {
            if (args.FirstOrDefault(x => x <= 0) == 0)
            {
                return false;
            }
            return true;
        }

    }
}