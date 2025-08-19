using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_System_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();

            IPayment creditCard = new CreditCardPayment();
            IPayment paypal = new PayPalPayment();
            IPayment bitcoin = new BitcoinPayment();

            processor.ProcessPayment(creditCard, 150.00m);
            processor.ProcessPayment(paypal, 250.50m);
            processor.ProcessPayment(bitcoin, 0.005m);
        }
    }
}
