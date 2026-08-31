
using TallerHerencia;

namespace Backend
{
    public class Rhombus: Square
    {   //Fields
        private double _d1, _d2;   

        //Propiety
        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }
        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }
        //Constructor
        public Rhombus(string name, double d1, double d2)
        {
            D1 = d1;
            D2 = d2;
        }
}

        // Private Method
        private double ValidateD1(double valueD1)
        {
            if (valueD1 <= 0)
            {
                throw new Exception($"{valueD1}/Error: the value must be greater than zero");
            }
            return valueD1;
        }
        private double ValidateD2(double valueD2)
        {
            if (valueD2 <= 0)
            {
                throw new Exception($"{valueD2}/Error: the value must be greater than zero");
            }
            return valueD2;
        }


    }
}
