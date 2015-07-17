using System;

namespace DefineClasses
{
    public class Display
    {
        // constants
        public const int DISPLAY_SIZE = 20;
        public const int NUMBER_OF_COLOURS = 5000;
        
        //fields
        private int displaySize;
        private int numberOfColours;

        //constructor without parameters
        public Display() : this (DISPLAY_SIZE, NUMBER_OF_COLOURS)
        {
        }

        //constructor with one parameter - display size
        public Display(int displaySize) : this(displaySize, NUMBER_OF_COLOURS)
        {
        }

        // full constructor with two parameters - displaySize and numberofColours
        public Display(int displaySize, int numberOfColours)
        {
            this.DisplaySize = displaySize;
            this.NumberOfColours = numberOfColours;
        }

        // properties
        public int DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value <= 0 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Display size should be > 0 and < 30");
                }
                this.displaySize = value;
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
                if (value <= 0 || value > 500000)
                {
                    throw new ArgumentOutOfRangeException("Number of colours should be > 0 and < 500000");
                }
                this.numberOfColours = value;
            }
        }
    }
}
