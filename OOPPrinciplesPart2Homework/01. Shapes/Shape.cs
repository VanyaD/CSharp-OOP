namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double size)
        {
            this.Width = size;
            this.Height = size;
        }

        public Shape(double width, double height) : this(width)
        {           
            this.Height = height;
        }

        public double Height
        {
            get { return height; }
            protected set 
            { 
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to zero");
                }

                height = value; 
            }
        }
        
        public double Width
        {
            get { return width; }
            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be less or equal to zero");
                } 

                width = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
