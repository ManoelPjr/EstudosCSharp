
namespace OOPExamples
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; private set; }

        public void toggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
