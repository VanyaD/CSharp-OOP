namespace _01.Shapes
{

    public class Square : Shape
    {
        
        public Square(double size) : base (size, size)
        {       
        }

        public override double CalculateSurface()
        {
            double squareSurface = this.Width * this.Width;

            return squareSurface;
        }
    }
}
