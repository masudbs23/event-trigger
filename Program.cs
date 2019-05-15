using System;

namespace event_trigger
{
    class Program
    {
        static void Main(string[] args)
        {
            var trigger = new DailyTrigger(16, 10, 25); // every day at 4:00pm

            trigger.OnTimeTriggered += () =>
            {
                Console.WriteLine("Funciton is triggered at :" + DateTime.Now);
            };

            Console.ReadKey();
        }
    }
}
