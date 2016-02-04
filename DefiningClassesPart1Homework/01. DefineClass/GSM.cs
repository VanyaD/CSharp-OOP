using System;
using System.Collections.Generic;

// • Define 3 separate classes (class  GSM  holding instances of the classes  Battery  and  Display ).

namespace DefineClasses
{
    public class GSM
    {
        public const string MODEL = "Unknown";
        public const string MANUFACTURER = "Unknown";
        public const decimal PRICE = 0m;
        public const string OWNER = "Uknown";

        private static GSM iPhone4S;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> callHistory;        

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public GSM (string model, string manufacturer) : this(model, manufacturer, PRICE, OWNER, new Battery(), new Display())
        {
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

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

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

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

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
            Console.WriteLine("Calls history cleared!");
        }

        public double CalculteTotalCallsPrice()
        {
            double totalPrice = 0;

            foreach (Call call in this.CallHistory)
            {
                totalPrice += call.Duration * call.PricePerMinute;
            }

            return totalPrice;
        }

        public override string ToString() 
        {
            string price = this.price.ToString();
            return "GSM Information: " + System.Environment.NewLine + 
                "Model: " + this.model + System.Environment.NewLine + 
                "Owner: " + this.owner + System.Environment.NewLine + 
                "Manufacturer: " + this.manufacturer + System.Environment.NewLine + 
                "Price: " + price;
        }
    }
}
