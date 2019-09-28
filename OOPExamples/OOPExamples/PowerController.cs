
namespace OOPExamples
{
    class PowerController: IPowerOn
    {
        public bool isOn { get; private set; }
        protected void TurnOn()
        {
            isOn = true;
        }
        protected void TurnOff()
        {
            isOn = false;
        }
        public virtual void togglePower()
        {
            if (isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }

    }
}
