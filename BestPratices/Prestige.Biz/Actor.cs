using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor born!");
        }
        public Actor(string actorName) : this()
        {
            ActorName = actorName;
        }
        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }

        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string GetOccupation()
        {
            jobTitle =  "Actor";
            return jobTitle;
        }
    }
}
