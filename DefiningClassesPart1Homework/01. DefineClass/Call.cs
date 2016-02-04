using System;
using System.Text;

namespace DefineClasses
{
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialledPhoneNumber;
        private int duration;
        private double pricePerMinute;

        public Call(string dialledPhoneNumber, int duration, double pricePerMinute)
        {
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Date = DateTime.Now.Date;
            this.Time = DateTime.Now.ToLocalTime();
            this.Duration = duration;
            this.PricePerMinute = pricePerMinute;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    
        public string DialledPhoneNumber
        {
            get { return dialledPhoneNumber; }
            set { dialledPhoneNumber = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public double PricePerMinute
        {
            get { return pricePerMinute; }
            set { pricePerMinute = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Date: {0}", this.Date));
            sb.AppendLine(string.Format("Time: {0}", this.Time));
            sb.AppendLine(string.Format("Dialled Number: {0}", this.DialledPhoneNumber));
            sb.AppendLine(string.Format("Duration: {0}", this.Duration));
            sb.AppendLine(string.Format("Price per minute: {0}", PricePerMinute));

            return sb.ToString();
        }
    }
}
