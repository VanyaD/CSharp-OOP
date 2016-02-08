namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double a, double height) : base(a, height)
        {
        }

        public override double CalculateSurface()
        {
            double triangleSurface = (this.Height * this.Width) / 2;
            return triangleSurface; 
        }
    }
}
