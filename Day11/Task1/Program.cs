using Task1;

class Program
{
    static void Main()
    {
        List<PaymentFactory> factories = new List<PaymentFactory>
        {
            new CardFactory(),
            new CryptoFactory(),
            new CashFactory()
        };

        foreach (var factory in factories)
        {
            IPayment payment = factory.CreatePayment();
            string result = payment.Pay(1000.00m);
            Console.WriteLine(result);
        }
    }
}