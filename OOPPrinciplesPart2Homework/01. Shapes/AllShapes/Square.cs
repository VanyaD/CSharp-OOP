namespace _01.Shapes
{

    public class Square : Shape
    {
        
        public Square(double size) : base (size)
        {       
        }

        public override double CalculateSurface()
        {
            double squareSurface = this.Width * this.Width;
            return squareSurface;
        }
    }
}
