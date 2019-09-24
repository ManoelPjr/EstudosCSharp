using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born.");
            //this.CurrentAgency = new Agency();
        }
        public Actor(string actorName) : this()
        {
            ActorName = actorName;
        }
        private string actotName;

        public string ActorName
        {
            get { return actotName; }
            set
            {
                var formattedName = value?.Trim();
                actotName = formattedName;
            }
        }

        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public int ActorAge { get; set; }
        public string ActorDescription { get; set; } = "Regular actor";

        private Agency currentAgency;

        public Agency CurrentAgency
        {
            get {
                if (currentAgency==null)
                {
                    currentAgency = new Agency();
                }
                return currentAgency;
            }
            set { currentAgency = value; }
        }


        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Books actor and not date specified.
        /// </summary>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Books actor on specific date.
        /// </summary>
        /// <param name="theDate"></param>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if" +
                " actor starts trouble.";
            string theActor = "Actor " + ActorName + " is booked";
            if (theDate != string.Empty)
            {
                return theActor + " on " + theDate + ". " + details;
            }
            else
            {
                return theActor + ". " + details;
            }

        }

        public string GetAgency()
        {
            //var currentAgency = new Agency();
            return CurrentAgency.Name;
        }
    }
}
    // Namespaces
    // Do
    // Follow format:
    // <Company>.<Technology>.<Feature>
    // Example: Microsoft.Media.Design
    // Use PascalCasing

    // Don't
    // Use 'system'
    // Use class name
    // I.e.
    // Namespace: Actor
    // Class: Actor

    // Method Overloading
    // Do
    // Include comments for the method and parameters
    // Use few parameters
    // Order the parameters consistently

    // Don't
    // Use overloads with same names but different purpose
    // Duplicate Code

    // Method Chaining
    // Do 
    // Implement to reduce repeated code

    // Don't
    // Use if it's overkill and complicating things

    // Properties: Best Pratices
    // Do
    // Use relevant names
    //Use 'getter' for simple protection, formatting, and initializing
    //Use 'setter' for simple protection, formatting, and validation

    // Don't
    // Abbreviate names
    // Use complex logic appropriate for methods

    // Auto-Implemented Properties: Best Pratices
    // Do
    // Use relevant names
    // Initialize the property when needed

    // Don't
    // Abbreviate names
    // Use logic that's better suited for getters and setters