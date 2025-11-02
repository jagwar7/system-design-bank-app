

public abstract class BankAccount : IAccount, IDepositable
{
    public string AccountHolder { get; }
    public decimal Balance { get; protected set; }

    protected BankAccount(string name, decimal balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"Amount must be greater than 0");
            return;
        }
        Balance += amount;
    }

    public decimal GetBalance() => Balance;
}