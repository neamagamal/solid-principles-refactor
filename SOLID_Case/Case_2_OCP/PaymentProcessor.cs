using System;

namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    //class PaymentProcessor
    //{
    //    public void ProcessPayment(string paymentType)
    //    {
    //        if (paymentType == "CreditCard")
    //        {
    //            // Process credit card payment
    //        }
    //        else if (paymentType == "PayPal")
    //        {
    //            // Process PayPal payment
    //        }
    //    }
    //}
    #endregion

    public interface IpaymentType
    {
        void ProcessPayment();
    }
    public class CreditCardPayment : IpaymentType
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Process credit card payment");
        }
    }
    public class PayPalPayment : IpaymentType
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal Payment");
        }
    }
    public class PaymentProcessor
    {
        public void ProcessPayment(IpaymentType IpaymentType)
        {
            IpaymentType.ProcessPayment();
        }
    }


}
