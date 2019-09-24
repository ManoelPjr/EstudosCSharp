using Proxy.Interfaces;

namespace Proxy.Classes
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    class CalculateProxy : IMath
    {
        private Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }
        public double Subtract(double x, double y)
        {
            return _math.Subtract(x, y);
        }
        public double Multiply(double x, double y)
        {
            return _math.Multiply(x, y);
        }
        public double Divide(double x, double y)
        {
            return _math.Divide(x, y);
        }
    }
}
