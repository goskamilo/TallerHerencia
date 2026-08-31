using Backend;

namespace TallerHerencia
{
    public class Square : GeometricFigure
    {

        //Fields
        private double _a;

       

        //Propierty
        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }
        //Constructor
        public Square(string name,double a)
        {
            Name = name;
            A = a;
        }


        // Private Method
        private double ValidateA(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{ value }/Error: the value must be greater than zero");
            }
            return value;
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
       
    }
}
