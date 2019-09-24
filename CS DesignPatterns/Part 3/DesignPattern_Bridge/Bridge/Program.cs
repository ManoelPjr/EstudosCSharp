using Bridge.Classes;
using Bridge.Interfaces;
using System;
/// <summary>
/// This code demonstrates the bridge pattern by sending messages using 
/// two independent systems. One by text & the other, webservice.
/// </summary>
namespace Bridge
{
    /// <summary>
    /// Bridge Design Pattern Demo
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            IMessageSender text = new TextSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "A Message";
            message.Body = "Hi there, Please accept this message.";

            message.MessageSender = text;
            message.Send();

            message.MessageSender = web;
            message.Send();

            Console.ReadKey();
        }
    }
}
