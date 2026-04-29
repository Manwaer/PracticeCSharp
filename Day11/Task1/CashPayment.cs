namespace Task1
{
    public class CashPayment : IPayment
    {
        public string Pay(decimal amount) => $"Оплата наличными: {amount} руб. принята через кассу.";
    }
}