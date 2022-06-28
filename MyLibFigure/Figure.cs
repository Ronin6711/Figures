namespace MyLibFigure
{
    public class Figure
    {
        const double Pi = 3.14;
        /// <summary>
        /// Площадь круга по радиусу
        /// </summary>
        /// <param name="Radius"></param>
        /// <returns></returns>
        public static double Square(double Radius)
        {
            double result;
            result = Pi * Math.Pow(Radius, 2);

            return Math.Round(result, 2);
        }
        /// <summary>
        /// Площадь треугольника по трём сторонам
        /// </summary>
        /// <param name="Side1"></param>
        /// <param name="Side2"></param>
        /// <param name="Side3"></param>
        /// <returns></returns>
        public static double Square(double Side1, double Side2, double Side3)
        {

            double result;
            double p = (Side1 + Side2 + Side3) / 2;
            result = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));

            return Math.Round(result, 2);
        }

        
    }
    public static class Check
    {
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="Side1"></param>
        /// <param name="Side2"></param>
        /// <param name="Side3"></param>
        /// <returns></returns>
        public static bool RightTriangle(double Side1, double Side2, double Side3)
        {

            bool result;

            if ((Side1 * Side1) + (Side2 * Side2) == Side3 * Side3 ||
               (Side1 * Side1) + (Side3 * Side3) == Side2 * Side2 ||
               (Side3 * Side3) + (Side2 * Side2) == Side1 * Side1)
            {
                result = true;
            }
            else
                result = false;

            return result;
        }
    }
}