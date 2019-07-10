using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    //In general terms, an event is something special that is going to happen. For example, Microsoft launches events
    //for developers, to make them aware about the features of new or existing products.Microsoft notifies the developers
    //about the event by email or other advertisement options.So in this case, Microsoft is a publisher who launches (raises) 
    //an event and notifies the developers about it and developers are the subscribers of the event and attend (handle)the event.

    //Events in C# follow a similar concept. An event has a publisher, subscriber, notification and a handler.
    //An event is nothing but an encapsulated delegate. As we have learned in the previous section, 
    //a delegate is a reference type data type.You can declare the delegate as shown below:

    //Points to Remember :
    //1.  Use event keyword with delegate type to declare an event.
    //2.  Check event is null or not before raising an event.
    //3.  Subscribe to events using "+=" operator. Unsubscribe it using "-=" operator.
    //4.  Function that handles the event is called event handler.Event handler must have same signature as declared by event delegate.
    //5.  Events can have arguments which will be passed to handler function.
    //6.  Events can also be declared static, virtual, sealed and abstract.
    //7.  An Interface can include event as a member.
    //8.  Events will not be raised if there is no subscriber
    //9.  Event handlers are invoked synchronously if there are multiple subscribers
    //10. The .NET framework uses an EventHandler delegate and an EventArgs base class.


    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number(100000);
            myNumber.PrintMoney();
            myNumber.PrintNumber();
            Console.ReadLine();
        }
    }
}
