

public abstract class BankAccount : IAccount, IDepositable
{
    public string AccountHolder { get; private set; }
    protected decimal Balance { get; protected set; };

    protected BankAccount(string name, decimal balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        
    }
}