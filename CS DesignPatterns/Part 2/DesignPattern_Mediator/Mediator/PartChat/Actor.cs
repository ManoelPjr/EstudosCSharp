using System;

namespace Mediator.PartChat
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class Actor : Participant
    {
        // Constructor
        public Actor(string name)
          : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To an Actor: ");
            base.Receive(from, message);
        }
    }
}
