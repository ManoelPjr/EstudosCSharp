using System;
using OOPExamples;

    class Program
    {
        static void Main(string[] args)
        {
        //var Comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
        var Comp = new Laptop("Generic Laptop", 1024, 768);

        Console.WriteLine("Computer type - "+ Comp.GetType());
        var isComputer = Comp is Computer;
        Console.WriteLine("Is computer? - "+ isComputer );
        Console.WriteLine("Computer Name: "+ Comp.name);
        //Console.WriteLine("Computer Case: " + Comp.caseType);
        Console.WriteLine("Computer is On? " + Comp.isOn);
        Comp.togglePower();
        Console.WriteLine("-----Power On-----");
        Console.WriteLine("Computer is On? " + Comp.isOn);

        var sleepingComp = Comp as ISleep;

        if (sleepingComp != null)
        {
            
            sleepingComp.toggleSleep();
            Console.WriteLine("-----Sleep On-----");
            Console.WriteLine("Computer is Sleeping? " + sleepingComp.isSleeping);

        }

        Comp.togglePower();
        Console.WriteLine("-----Power Off-----");
        Console.WriteLine("Computer is On? " + Comp.isOn);
        Console.Read();
        }
    }

