
using System.Dynamic;

namespace Backend
{
    public abstract class GeometricFigure
    {

        // Propierties
       
        // Methods
        public string Name
        {
            get;
            set;
        }
        // Methods
        public abstract double GetArea();
        public abstract double GetPerimiter();
        public override string ToString()
        {
            return $"{Name}- Area: {GetArea():D4}/Perimeter: {GetPerimiter():D4}";
        }


    }
}
