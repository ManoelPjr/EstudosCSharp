using Prototype.Classes;
using System;
/// <summary>
/// This code demonstrates the Prototype pattern in which new 
/// Color objects are created by copying pre-existing, user-defined
/// Colors of the same type.
/// </summary>
namespace Prototype
{
    /// <summary>
    /// Prototype Design Pattern.
    /// </summary>
    class Program
    {
        static void Main()
        {
            ColorController colorController = new ColorController();

            // Initialize with standard colors
            colorController["yellow"] = new Color(255, 255, 0);
            colorController["orange"] = new Color(255, 128, 0);
            colorController["purple"] = new Color(128, 0, 255);

            // User adds personlized colors
            colorController["sunny"] = new Color(255, 54, 0);
            colorController["tasty"] = new Color(255, 153, 51);
            colorController["rainy"] = new Color(255, 0, 255);

            // User clones selected colors
            Color c1 = colorController["yellow"].Clone() as Color;
            Color c2 = colorController["tasty"].Clone() as Color;
            Color c3 = colorController["rainy"].Clone() as Color;

            // Wait for user
            Console.ReadKey();
        }
    }






}
