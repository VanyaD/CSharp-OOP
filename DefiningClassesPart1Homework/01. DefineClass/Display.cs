using System;

namespace DefineClasses
{
    public class Display
    {
        public const int DEFAULT_DISPLAY_SIZE = 20;
        public const int DEFAULT_NUMBER_OF_COLOURS = 5000;
        
        private int size;
        private int numberOfColours;

        public Display() : this (DEFAULT_DISPLAY_SIZE, DEFAULT_NUMBER_OF_COLOURS)
        {
        }

        public Display(int displaySize) : this(displaySize, DEFAULT_NUMBER_OF_COLOURS)
        {
        }

        public Display(int displaySize, int numberOfColours)
        {
            this.DisplaySize = displaySize;
            this.NumberOfColours = numberOfColours;
        }

        public int DisplaySize
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0 || value >= 30)
                {
                    throw new ArgumentOutOfRangeException("Display size should be in the interval (0, 30)");
                }

                this.size = value;
            }
        }

        public int NumberOfColours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                if (value <= 0 || value >= 500000)
                {
                    throw new ArgumentOutOfRangeException("Number of colours should be in the interval (0, 500000)");
                }

                this.numberOfColours = value;
            }
        }
    }
}
