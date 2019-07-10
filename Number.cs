using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    //All the subscribers must provided a handler function, which is going to be called when a publisher raises an event.
    //In the above example, the Number class creates an instance of PrintHelper and subscribes to the beforePrintEvent 
    //with the "+=" operator and gives the name of the function which will handle the event (it will be get called when publish fires an event). 
    //printHelper_beforePrintEvent is the event handler that has the same signature as the BeforePrint delegate in the PrintHelper class.

    class Number
    {
        PrintHelper printHelper = new PrintHelper();
        public int Value { get; set; }

        public Number(int val)
        {
            Value = val;
            //subscribe to beforePrintEvent event. To subscribe to an event, you will look at the events of the print helper class
            // and add your method which will be called when publisher fires an event.

            printHelper.beforePrintEvent += helperEventToBeRaised;
        }

        //beforePrintevent handler
        //This function will be called when publish fires an event
        void helperEventToBeRaised()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }
     
        public void PrintMoney()
        {
            //You are calling a function of print helper which checks if anyone has subscribed to their event, if yes
            // then it calls a method which is handled by client class
            printHelper.PrintMoney(Value);
        }

        public void PrintNumber()
        {
            //You are calling a function of print helper which checks if anyone has subscribed to their event, if yes
            // then it calls a method which is handled by client class
            printHelper.PrintNumber(Value);
        }
    }
}
