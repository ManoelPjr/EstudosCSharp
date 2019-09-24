using Mediator.Chat;
using Mediator.PartChat;
using System;
/// <summary>
/// This code demonstrates the Mediator pattern facilitating loosely 
/// coupled communication between different Participants registering 
/// with a Chatroom. The Chatroom is the central hub through which all 
/// communication takes place.
/// </summary>
namespace Mediator
{
    /// <summary>
    /// Mediator Design Pattern.
    /// </summary>
    class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {

            // Create chatroom
            Chatroom chatroom = new Chatroom();

            Participant Eddie = new Actor("Eddie");
            Participant Jennifer = new Actor("Jennifer");
            Participant Bruce = new Actor("Bruce");
            Participant Tom = new Actor("Tom");
            Participant Tony = new NonActor("Tony");

            // Create participants and register them
            chatroom.Register(Eddie);
            chatroom.Register(Jennifer);
            chatroom.Register(Bruce);
            chatroom.Register(Tom);
            chatroom.Register(Tony);

            // Chatting participants
            Tony.Send("Tom", "Hey Tom! I got a mission for you.");
            Jennifer.Send("Bruce", "Teach me to act and I'll" +
                " teach you to dance");
            Bruce.Send("Eddie", "How come you don't do standup anymore?");

            Jennifer.Send("Tom", "Do you like math?");
            Tom.Send("Tony", "Teach me to sing.");

            // Wait for user
            Console.ReadKey();

        }
    }

    

 






}
