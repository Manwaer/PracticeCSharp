using System;

abstract class BankAccount
{
    public double Balance { get; set; }

    public BankAccount(double balance)
    {
        Balance = balance;
    }

    public abstract double CalculateInterest();

    public virtual void DisplayBalance()
    {
        Console.WriteLine($"Баланс: {Balance}");
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(double balance, double rate) : base(balance)
    {
        InterestRate = rate;
    }

    public override double CalculateInterest()
    {
        return Balance * InterestRate;
    }

    public override void DisplayBalance()
    {
        Console.WriteLine($"Сберегательный счет. Баланс: {Balance}");
    }
}

class CurrentAccount : BankAccount
{
    public double InterestRate { get; set; }

    public CurrentAccount(double balance, double rate) : base(balance)
    {
        InterestRate = rate;
    }

    public override double CalculateInterest()
    {
        return Balance * InterestRate;
    }

    public override void DisplayBalance()
    {
        Console.WriteLine($"Текущий счет. Баланс: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new SavingsAccount(1000, 0.05);
        BankAccount acc2 = new CurrentAccount(2000, 0.02);

        acc1.DisplayBalance();
        Console.WriteLine($"Проценты: {acc1.CalculateInterest()}");

        acc2.DisplayBalance();
        Console.WriteLine($"Проценты: {acc2.CalculateInterest()}");
    }
}