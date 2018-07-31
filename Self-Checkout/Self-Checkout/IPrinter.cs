using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCheckout
{
    /// <summary>
    /// Prints reciept.
    /// </summary>
    interface IPrinter
    {
        /// <summary>
        /// Prints a given reciepts
        /// </summary>
        /// <param name="recipet"></param>
        void PrintReciept(Recipet recipet);
    }
}
