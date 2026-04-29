namespace Task1
{
    public class CryptoPayment : IPayment
    {
        public string Pay(decimal amount) => $"Оплата криптовалютой: {amount} руб. Подтверждение в блокчейне...";
    }
}