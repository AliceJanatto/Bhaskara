namespace Bhaskara
{
    public static class BhaskaraExemplo
    {
        public static (double, double) CalcularRaizes(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return x1 < x2 ? (x1, x2) : (x2, x1);
            }
            else
            {
                throw new InvalidOperationException("Sua equação não possui duas raízes reais!");
            }
        }
    }
}
