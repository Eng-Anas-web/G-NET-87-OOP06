using System.Drawing;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Timers;

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

            #region Question03
            //Q03
            //a) What is a static field, and how is it different from an instance field?
            //A: Static Field: Belongs to the class itself rather than any specific instance. There is only one copy of a static field shared across all objects of that class.
            //Instance Field: Belongs to a specific object.Every time you create a new object, a separate copy of the instance field is created for that specific object.
            //b) What is a static method? Can a static method directly access instance members?
            //A: What is it? A method that belongs to the class itself, so you can call it without creating an object.
            // Can it access instance members? No, it cannot directly access normal instance members because it doesn't belong to any specific object.
            //c) What is a static constructor, and when is it executed?
            //A: What is it? A special constructor used to initialize static members.
            //When is it executed ? It runs automatically only once the very first time the class is accessed, and it cannot be called manually.
            //d) What is a static class? Can you create an object from a static class?
            //A: What is it? A class that contains only static members and cannot be instantiated.
            // Can you create an object from it? No, you cannot create an object from a static class using the new keyword. 
            #endregion

            #region Question04

            //Q04
            //a) What is an Extension Method?
            //A: It is a special method that allows you to add new methods to an existing class or interface without modifying its original source code or creating a new derived class.
            //b) What keyword must be used in the first parameter of an extension method?
            //A: this
            //c) Where must an extension method be declared?
            //A: It must be declared inside a static class.
            //d) Can an extension method access private members of the class it extends?
            //A: No, an extension method cannot access private or protected members of the class it extends; it can only access its public members. 
            #endregion

        }
    }
}
