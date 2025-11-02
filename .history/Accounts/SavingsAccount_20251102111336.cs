

public class SavingsAccount : BankAccount, IWithdrawable
{
    private const decimal minBalance = 500
    public SavingsAccount(string name, decimal intialBalance) : base(name, intialBalance)
    {
        if(intialBalance <=0)
    }
    
    public void Withdraw(decimal amount)
    {
        
    }
}