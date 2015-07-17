using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// • Define 3 separate classes (class  GSM  holding instances of the classes  Battery  and  Display ).

namespace DefineClasses
{
    public class GSM
    {
        // constants
        public const string MODEL = "Unknown";
        public const string MANUFACTURER = "Unknown";
        public const decimal PRICE = 0m;
        public const string OWNER = "Uknown";

        // static fields (class variables)
        private static GSM iPhone4S;

        // class fields (instance variables)
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        // constructors
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM (string model, string manufacturer) : this(model, manufacturer, PRICE, OWNER, new Battery(), new Display())
        {
        }

        // properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty.");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than zero.");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be null or empty.");
                }
                this.owner = value;
            }
        }

        //static property
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public override string ToString() 
        {
            string s = this.price.ToString();
            return "GSM Information: " + System.Environment.NewLine + 
                "Model: " + this.model + System.Environment.NewLine + 
                "Owner: " + this.owner + System.Environment.NewLine + 
                "Manufacturer: " + this.manufacturer + System.Environment.NewLine + 
                "Price: " + s;
        }

    }
}
