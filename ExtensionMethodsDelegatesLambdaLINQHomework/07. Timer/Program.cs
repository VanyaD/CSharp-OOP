using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 7. Timer
// • Using delegates write a class  Timer  that can execute certain method at each  t  seconds.


namespace _07.Timer
{
    public class Timer
    {
        private const int T = 10;

        private DateTime time;

        public DateTime Time
        {
            get
            {
                return this.time;
            }

            private set
            {
                this.Time = DateTime.Now;
            }
        }

        public Timer()
        {
            this.Time = DateTime.Now;
        }

        public static void DoNow()
        {
            DateTime testTimer = new DateTime();

            while (true)
            {
                DateTime newTime = testTimer.AddSeconds(T);

                if (DateTime.Now == newTime)
                {
                    Console.WriteLine("Method invoked");
                }
            }
        }
        //public delegate void SomeDelegate(); 
        //SomeDelegate += DoNow;

        static void Main(string[] args)
        {
            Timer test = new Timer();
            test.DoNow();
        }
    }
}
