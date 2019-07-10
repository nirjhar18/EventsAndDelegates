using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    //Events can also pass data as an argument to their subscribed handler. An event passes arguments to the handler as per the delegate signature.
    //In the following example, PrintHelper declares the BeforePrint delegate that accepts a string argument. So now, you can pass a string
    //when you raise an event from PrintNumber or any other Print method.
    class PrintHelperWithArguements
    {
        public delegate void BeforePrint(string message);

        public event BeforePrint beforePrintEvent;

        public void PrintNumber(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("Print Number");

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintDecimal");

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintMoney");

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintTemerature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }

        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
