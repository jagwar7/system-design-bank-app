

public abstract class BankAccount : IAccount, IDepositable
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    protected BankAccount(string name, decimal balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        Console.WriteLine($"Balance deposited: {amount}")
    }
}