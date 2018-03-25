
using System;
using System.Runtime.InteropServices;
using CrossPILibrary;

namespace CrossPITestApp
{
    public static class Program
    {
        [DllImport("CrossPIDll.dll")]
        private static extern void TheDllFunction([MarshalAs(UnmanagedType.LPWStr)] string str);

        delegate void TheDelegate([MarshalAs(UnmanagedType.LPWStr)] string str);

        [DllImport("CrossPIDll.dll")]
        private static extern void TakeTheDelegate(TheDelegate del);
        [DllImport("CrossPIDll.dll")]
        private static extern void CallTheDelegate();

        static void DelegateImpl([MarshalAs(UnmanagedType.LPWStr)] string str)
        {
            Console.WriteLine("This is the delegate implementation speaking! {0}", str);
        }

        static void Main(string[] args)
        {
            PIClass lib = new PIClass();
            lib.DoIt();

            TheDllFunction("Parameter string");
            TakeTheDelegate(DelegateImpl);
            CallTheDelegate();
            Console.WriteLine("Hello World!");
        }
    }
}
