
namespace OOPExamples
{
    class Laptop : Computer, ISleep 
    {
        private ISleep sleepController;
        public Display display { get; private set; }

        public bool isSleeping 
        {
            get { return sleepController.isSleeping; }
        }

        public Laptop(string name, int width, int height) : base(name)
        {
            display = new Display(width, height);
            sleepController = new SleepController();
        }

        public void toggleSleep()
        {
            sleepController.toggleSleep();
        }
    }
}
