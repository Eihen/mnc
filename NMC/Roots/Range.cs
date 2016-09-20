namespace MNC.Roots
{
    public class Range
    {
        double _a, _b;

        public Range(double a, double b)
        {
            this._a = a;
            this._b = b;
        }

        public double a
        {
            get { return _a; }
            set { _a = value; }
        }

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }
    }
}
