

public abstract class BankAccount : IAccount, IDepositable
{
    public string AccountHolder { get; protected set; }
    public decimal Balance { get; private set; }

    protected BankAccount(string name, decimal balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    // Can be overriden this function in Child class
    public virtual void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Balance deposited: {amount} , Current Balance: {Balance}");
            return;
        }
        Console.WriteLine($"Can not deposit amount less than 1");
    }

    public decimal GetBalance() => Balance;
}