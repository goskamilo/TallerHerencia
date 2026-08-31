
namespace Backend
{
    public class Kite : Rhombus
    {
        //Fields
        private double _b;
      
        //Property
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }
        //Constructor
        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            _b = b;
        }
        // Private Method
        private double ValidateB(double value)
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
            return (D1 * D2) / 2;
        }
        public override double GetPerimiter()
        {
            return 2*(A + B);
        }
    }
}
