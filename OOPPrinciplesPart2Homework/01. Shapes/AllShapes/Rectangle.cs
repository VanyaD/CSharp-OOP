namespace _01.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double rectangleSurface = this.Height * this.Width;
            return rectangleSurface;
        }
    }
}
