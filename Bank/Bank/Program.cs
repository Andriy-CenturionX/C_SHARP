using System;

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Початковий баланс не може бути від’ємним");

        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сума поповнення некоректна");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сума зняття некоректна");

        if (amount > Balance)
            throw new InvalidOperationException("Недостатньо коштів");

        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(10000);

            Console.WriteLine($"Початковий баланс: {account.Balance}");

            account.Deposit(5200);
            Console.WriteLine($"Після поповнення: {account.Balance}");

            account.Withdraw(2750);
            Console.WriteLine($"Після зняття: {account.Balance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
