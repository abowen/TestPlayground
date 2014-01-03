using TestPlayground.Business.Interfaces;

namespace TestPlayground.Business.Entities
{
    public class Triangle : IShape
    {
        private readonly int _length;

        public Triangle(int length)
        {
            _length = length;
        }

        public int Sides
        {
            get { return 3; }
        }

        public string Description { get { return "Triangle"; } }

        public int SurfaceArea { get { return _length * _length / 2; } }
    }
}
