using Observer.Observer;
using Observer.Subject;
using System;

namespace Observer.ConcreteObserver
{
    // Concrete object
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: "+
                $"{celebrity.Tweet}");
        }
    }
}
