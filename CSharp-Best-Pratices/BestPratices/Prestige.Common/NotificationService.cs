using System;

namespace Prestige.Common
{
    /// <summary>
    /// Notifies Talent
    /// </summary>
    static public class NotificationService
    {
        static public string NotifyTalent(string talentName)
        {
            var message = "Notifying talent: " + talentName;
            Console.WriteLine(message);
            return message;
        }
    }

    // Static classes
    // Do
    // Use static classes sparingly
    // Use for common utilities

    // Don't
    // Use as random bucket

    // Singletons
    // Do
    // Use when you only need one instance
    // Use when you need to create 'child objects'
    // Use to support OOP features
    
    // Don't
    // Use if you won't leverage any of the aforementioned features

}
