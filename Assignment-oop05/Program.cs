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

            #region Question02
            //Q02
            //a) What is a Shallow Copy?
            //A: A Shallow Copy creates a new object for the main object itself, but for any reference-type members inside it (like nested objects), it only copies their references. As a result, the copied object and the original object end up sharing the exact same inner reference-type objects.
            //b) What is a Deep Copy?
            //A: A Deep Copy creates a completely new object, and it also creates new, independent copies of all its reference-type members (nested objects). This means the original and the copied object are entirely separate, and they do not share references to any inner objects.
            //c) What happens to reference-type members when a Shallow Copy is created?
            //A: When a Shallow Copy is created, reference-type members are not duplicated; instead, their references are copied, meaning both the original and the copied object point to the exact same reference-type objects in memory.ترجم كدا
            //d) What happens to reference-type members when a Deep Copy is created?
            //A: When a Deep Copy is created, new, independent copies of all reference-type members are created, meaning they get their own new references and do not share anything with the original object.
            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //A: When duplicating an object (like a Shipment) that contains reference-type properties (like a DeliveryAddress), a Deep Copy is safer because modifying the nested properties of the copied object will not accidentally alter or corrupt the data of the original object. 
            #endregion
        }
    }
}
