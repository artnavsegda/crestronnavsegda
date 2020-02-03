using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes

namespace http_sharp
{
    // Define the delegate:

    public delegate short DelegateComputeFn();
    public delegate string DelegateFn(uint id);

    // Create a property in a class:

    public class DelegateTest
    {

        // non-static property
        public DelegateComputeFn ComputeFn { get; set; }
        // static property
        static public DelegateFn StaticFn { get; set; }

        private short Compute()
        {

            short ret = 0;
            // Call the mapped function in SIMPL+
            // * remember to check for null in case *
            // *   the function was never mapped!   *
            if (ComputeFn != null)
                ret = ComputeFn();
            return ret;
        }
    } 
}
