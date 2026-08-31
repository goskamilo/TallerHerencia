using Backend;

namespace TallerHerencia
{
    public class Square : GeometricFigure
    {

        //Fields
        private double _a;
        //Constructor
        public Square(double A)
        {
           _a= A;
        }

        //Propierty
        public double A
        {
            get  => _a;
            set => _a=ValidateA(value);
        }    
        // Methods
        public override double GetArea()
        {
            return A * A;
        }
        public override double GetPerimiter()
        {
            return 4 * A;
        }
        // Private Method
        private double ValidateA(double value)
        {
            if (value <= 0)
            {
                Console.WriteLine($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }
    }
}
