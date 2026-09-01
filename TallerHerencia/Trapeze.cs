namespace Backend
{
    public class Trapeze : Triangle
    {
        //FIELD
        private double _d;
        //CONSTRUCTOR
        public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
        {
            Name = name;
            _d = d;
        }
        //PROPERTY
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }
        //METHODS
        public override double GetArea()
        {
            return ((A + B) * H) / 2;
        }
        public override double GetPerimiter()
        {
            return A + B + C + D;
        }
        //PRIVATE METHOD
        private double ValidateD(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }
    }
}
