
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

        } = string.Empty;
        // Methods
        public abstract double GetArea();
        public abstract double GetPerimiter();
        public override string ToString()
        {
            return $"{Name,-15}     =>Area.....: {GetArea(),15:N5}     Perimeter:       {GetPerimiter(),15:N5}";
        }


    }
}
