namespace Task1
{
    public class CashFactory : PaymentFactory
    {
        public override IPayment CreatePayment() => new CashPayment();
    }

    public class CardFactory : PaymentFactory
    {
        public override IPayment CreatePayment() => new CardPayment();
    }

    public class CryptoFactory : PaymentFactory
    {
        public override IPayment CreatePayment() => new CryptoPayment();
    }
}