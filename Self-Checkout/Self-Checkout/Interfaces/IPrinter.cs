using SelfCheckout;
using Self_Checkout.Models.Payment;

namespace Self_Checkout.Interfaces
{
    /// <summary>
    /// Prints reciept.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Prints a given reciepts
        /// </summary>
        /// <param name="recipet"></param>
        void Print(Recipet recipet);
    }
}
