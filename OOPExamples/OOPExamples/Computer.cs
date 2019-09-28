
namespace OOPExamples
{
    abstract class Computer: IPowerOn
    {
        protected IPowerOn powerController;
        protected string _name = "Unknow";
        public bool isOn { get { return powerController.isOn; } }

        public Computer(string name)
        {
            this.name = name;
            powerController = new PowerController();
        }

        public virtual string name { 
            get 
            { 
                return _name; 
            } 
            private set
            { 
                _name = value; 
            } 
        }
        
        public virtual void togglePower()
        {
            powerController.togglePower();
        }
    }
}
