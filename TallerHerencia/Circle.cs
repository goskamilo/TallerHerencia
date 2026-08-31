namespace Backend
{
    public class Circle : GeometricFigure
    {

        //Fields
        private double _r;
        //Propiety
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }
        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }
        // Private Method
        private double ValidateR(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }
        // Methods
        public override double GetArea()
        {
            return   Math.PI * Math.Pow(R, 2);
        }
        public override double GetPerimiter()
        {
            return (2*Math.PI) * R;
        }
    }
}
