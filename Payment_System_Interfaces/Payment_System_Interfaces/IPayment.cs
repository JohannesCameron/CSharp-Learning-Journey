using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_System_Interfaces
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPayment
    { 
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} usiing Credit Card.");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} usiing PayPal.");
        }
    }

    public class BitcoinPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} usiing Bitcoin.");
        }
    }

    public class PaymentProcessor
    {
        public void ProcessPayment(IPayment paymentMethod, decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }

}
