using Task3;

class Program
{
    static void Main()
    {
        OrderSystem kitchen = new OrderSystem();
        OrderInvoker waiter = new OrderInvoker();

        ICommand orderPizza = new PlaceOrderCommand(kitchen, "Пицца Семён");
        waiter.SetCommand(orderPizza);
        Console.WriteLine(waiter.Invoke());

        ICommand cancelPizza = new CancelOrderCommand(kitchen, "Пицца Семён");
        waiter.SetCommand(cancelPizza);
        Console.WriteLine(waiter.Invoke());
    }
}