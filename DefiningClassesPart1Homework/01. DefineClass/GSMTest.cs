using System;

namespace DefineClasses
{
    class GSMTest
    {
        static void Main()
        {          
            GSM gsmInstance1 = new GSM("Galaxy", "Samsung");            
            GSM gsmInstance2 = new GSM("Galaxy", "Samsung", 1200, "Samsung", new Battery(), new Display());

            GSM[] gsmInstances =  {gsmInstance1, gsmInstance2};

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(gsmInstances[i]);
                Console.WriteLine("------------------");
            }
        }              
    }
}
