using Strategy.Classes;
using System;
/// <summary>
/// This code demonstrates the Strategy pattern which encapsulates 
/// sorting algorithms in the form of sorting objects. This allows 
/// clients to dynamically change sorting strategies including 
/// Quicksort, Shellsort, and Mergesort.
/// </summary>
namespace Strategy
{
    /// <summary> 
    /// Strategy Design Pattern.
    /// </summary>
    class Client
    {
        static void Main()
        {
            SortedList studentRecord = new SortedList();

            studentRecord.Add("Ronny");
            studentRecord.Add("Bobby");
            studentRecord.Add("Kate");
            studentRecord.Add("Mike");
            studentRecord.Add("Ricky");

            studentRecord.SetSortStrategy(new QuickSort());
            studentRecord.Sort();

            studentRecord.SetSortStrategy(new ShellSort());
            studentRecord.Sort();

            studentRecord.SetSortStrategy(new MergeSort());
            studentRecord.Sort();

            // Wait for user
            Console.ReadKey();

        }
    }
}
