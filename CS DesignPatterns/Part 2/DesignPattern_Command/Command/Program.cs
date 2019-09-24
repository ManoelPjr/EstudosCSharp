using Command.Invoker;
using System;
/// <summary>
/// This code demonstrates the Command pattern used in a simple calculator 
/// with unlimited number of undo's and redo's. Note that in C#  the 
/// word 'operator' is a keyword. Prefixing it with '@' allows using it 
/// as an identifier.
/// </summary>
namespace Command
{
    /// <summary>
    /// Command Design Pattern.
    /// </summary>
    class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create User & let then compute
            User user = new User();

            // Use press calculate buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            //Redo 3 commands
            user.Redo(3);

            // Wait for user

            Console.ReadKey();

        }
    }
}
