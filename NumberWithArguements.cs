using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class NumberWithArguements
    {
        PrintHelperWithArguements printHelper = new PrintHelperWithArguements();
        public int Value { get; set; }

        public NumberWithArguements(int val)
        {
            Value = val;

            //subscribe to beforePrintEvent event. To subscribe to an event, you will look at the events of the print helper class
            // and add your method which will be called when publisher fires an event.

            printHelper.beforePrintEvent += helperEventToBeRaised;
        }

        //beforePrintevent handler
        //This function will be called when publish fires an event
        void helperEventToBeRaised(string message)
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelperWithArguements is going to print a value from {0}", message);
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
