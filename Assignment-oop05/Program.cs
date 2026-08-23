using System.Drawing;
using System.Net;
using System.Threading.Channels;

namespace Assignment_oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q01
            //a) What happens when you assign one object variable to another object variable?
            //A: Both variables reference the same object
            //b) Does assigning one object to another create a new object? Explain.
            //A: No, assigning one object to another does not create a new object.
            //When you assign one object variable to another, you are only copying the reference(the memory address), not the actual object itself. As a result, both variables point to the exact same object in memory, meaning any changes made through one variable will affect the other.
            //c) What is the difference between copying an object and copying its reference?
            //A: Copying the object itself: Creates a brand new object in memory (on the Heap) with its own separate memory address, meaning changes made to the new object will not affect the original one.
            // Copying its reference: Only copies the memory address(the reference), so both variables point to the exact same object in memory, and any modifications through one will affect the other. 
            #endregion
        }
    }
}
