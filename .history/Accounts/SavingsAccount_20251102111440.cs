

public class SavingsAccount : BankAccount, IWithdrawable
{
    private const decimal minBalance = 500m;
    public SavingsAccount(string name, decimal intialBalance) : base(name, intialBalance)
    {
        if(intialBalance < minBalance)
        {
            throw new ArgumentException($"Initials")
        }
    }
    
    public void Withdraw(decimal amount)
    {
        
    }
}