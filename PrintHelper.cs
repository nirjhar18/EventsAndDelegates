using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    //PrintHelper is a publisher class that publishes the beforePrint event. Notice that in each print method, 
    //it first checks to see if beforePrintEvent is not null and then it calls beforePrintEvent().
    //beforePrintEvent is an object of type BeforPrint delegate, so it would be null if no class is subscribed to the event 
    //and that is why it is necessary to check for null before calling a delegate.

    class PrintHelper
    {
        //Step 1: Declare a delegate
        //This step is not required if you are using C# 3.0. You can use Func or Action inbuilt delegates
        public delegate void BeforePrint();

        //Step 2: declare event of type delegate
        //Print Helper class has an event that subscribers can subscribe to. A class can have multiple events.
        //To declare an event, use the event keyword before declaring a variable of delegate type
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {

        }

        public void PrintNumber(int num)
        {
            //call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
