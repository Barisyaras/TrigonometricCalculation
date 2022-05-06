namespace Calculation
{
    public class TrigonometricCalculation
    {
        public double CovertAngleToRadian(double angle)
        {
            return angle * (Math.PI / 180);
        }

        

        public double CalculateSinusByRadian(double radian)
        {
            return Math.Sin(radian);
        }

        

        public double CalculateCosinusByRadian(double radian)
        {
            return Math.Cos(radian);
        }

        

        public double CalculateTangentByRadian(double radian)
        {
            return Math.Tan(radian);
        }

        

        public double CalculateCotangentByRadian(double radian)
        {
            return 1 / Math.Tan(radian);
        }

        public void WriteRoundedCalculation(double value) 
        {
            double roundedValue =Math.Round(value, 3);
            Console.WriteLine(roundedValue);
        }
    }
}
