using System;

public class BankAccount
{
    public string AccountNumber { get; }

    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("UA123456", 1000);

        account.Deposit(300);
        account.Withdraw(250);

        Console.WriteLine($"Рахунок: {account.AccountNumber}");
        Console.WriteLine($"Баланс: {account.Balance}");
    }
}