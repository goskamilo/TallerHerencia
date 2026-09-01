
using TallerHerencia;

namespace Backend
{
    public class Rectangle : Square
    {
        //FIELD
        private double _b;
        //CONSTRUCTOR
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            Name = name;
            _b = b;
        }
        //PROPERTY
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }      
        //METHODS
        public override double GetArea()
        {
            return A * B;
        }
        public override double GetPerimiter()
        {
            return 2 * (A + B);
           
        }
        //PRIVATE METHOD
        private double ValidateB(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }
    }
}
