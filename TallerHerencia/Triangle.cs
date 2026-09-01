namespace Backend
{
    public class Triangle :Rectangle
    {
        //FIELDS
        private double _c; private double _h;
        // CONSTRUCTOR
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            _c = c;
            _h = h;
        }
        //PROPERTY
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }
        public double H
        {
            get => _h;
            set => _h = Validate(value);
        }
        //METHODS
        public override double GetArea()
        {
            return (B * H) / 2;
        }
        public override double GetPerimiter()
        {
            return A + B + C;
        }
        //PRIVATE METHOD
        private double ValidateC(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }
        private double Validate(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }

    }
}
