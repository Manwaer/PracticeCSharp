namespace Task1
{
    public class CardPayment : IPayment
    {
        public string Pay(decimal amount) => $"Оплата картой: {amount} руб. Проведение транзакции через банк...";
    }
}