using ChainofResponsibility.ClassHolding;
using ChainofResponsibility.ConcreteHandler;
using ChainofResponsibility.Handler;
using System;
/// <summary>
/// This code demonstrates the Chain of Responsibility pattern in which 
/// several linked managers and executives can respond to a purchase 
/// request or hand it off to a superior. Each position has can have 
/// its own set of rules which orders they can approve.
/// </summary>
namespace ChainofResponsibility
{
    /// <summary>
    /// Chain of Responsibility Design Pattern.
    /// </summary>
    class Client
    {
        static void Main()
        {
            // Setup chain of responsability
            Approver ronny = new Director();
            Approver bobby = new VicePresident();
            Approver rick = new President();

            ronny.SetSuccessor(bobby);
            bobby.SetSuccessor(rick);

            // Generate and process purchase requests

            Purchase p = new Purchase(1000, 350.00, "Assets");
            ronny.ProcessRequest(p);
            p = new Purchase(1001, 33390.10, "Project Poison");
            ronny.ProcessRequest(p);
            p = new Purchase(1002, 144400.00, "Project BBD");
            ronny.ProcessRequest(p);

            // Wait for client
            Console.ReadKey();

        }
    }
}
//-------------------------------------------
//class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
