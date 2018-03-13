
using System;
using System.Runtime.InteropServices;
using CrossPILibrary;

namespace CrossPITestApp
{
    public static class Program
    {
        [DllImport("CrossPIDll.dll")]
        private static extern void TheDllFunction();

        delegate void TheDelegate();

        [DllImport("CrossPIDll.dll")]
        private static extern void TakeTheDelegate(TheDelegate del);

        static void DelegateImpl()
        {
            Console.WriteLine("This is the delegate implementation speaking!");
        }

        static void Main(string[] args)
        {
            PIClass lib = new PIClass();
            lib.DoIt();

            TheDllFunction();
            TakeTheDelegate(DelegateImpl);
            Console.WriteLine("Hello World!");
        }
    }
}
