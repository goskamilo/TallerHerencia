namespace Backend
{
    public class Parallelogram: Rectangle
    {
        //FIELD
        private double _h;
                //CONSTRUCTOR
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            Name = name;    
            _h = h; 
        }
        //PROPERTY  
            public double H 
            {
                get => _h;
                set => _h = ValidateH(value);
            }
        //METHODS
        public override double GetArea()
        {
            return B * H;
        }
        public override double GetPerimiter()
        {
            return 2 * (A + B);
        }
        //PRIVATE METHOD
        private double ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"{value}/Error: the value must be greater than zero");
            }
            return value;
        }

    }
}
