namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double triangleSurface = 0;
            triangleSurface = (this.Height * this.Width) / 2;

            return triangleSurface; 
        }
    }
}
