using DefineClasses;
using System;
using System.Linq;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("Galaxy", "Samsung");
            gsm.AddCall(new Call("+359884211", 1, 0.5));
            gsm.AddCall(new Call("+359884212", 2, 0.5));
            gsm.AddCall(new Call("+359884213", 3, 0.5));
            gsm.AddCall(new Call("+359884214", 4, 0.2));

            Console.WriteLine("Call History:");
            Console.WriteLine();

            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine("Total Calls Price: {0}", gsm.CalculteTotalCallsPrice());

            var longestCall = gsm.CallHistory
                .OrderByDescending(x => x.Duration)
                .First();
  
            gsm.DeleteCall(longestCall);

            Console.WriteLine("Total Calls Price after longest call is deleted: {0}", gsm.CalculteTotalCallsPrice());

            gsm.ClearHistory();

            if (gsm.CallHistory.Count == 0)
            {
                Console.WriteLine("No calls in calls history available!");
            }
        }
    }
}
