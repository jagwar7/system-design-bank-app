

public class SavingsAccount : BankAccount, IWithdrawable
{
    private const decimal minBalance = 500m;
    public SavingsAccount(string name, decimal intialBalance) : base(name, intialBalance)
    {
        if(intialBalance < minBalance)
        {
            throw new ArgumentException($"Initial balance should be : {minBalance}");
        }
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be positive");
        }
        
        if(Balance - amount >= )
    }
}