

public class SavingsAccount : BankAccount, IWithdrawable
{
    private const 
    public SavingsAccount(string name, decimal intialBalance) : base(name, intialBalance)
    {
        if(intialBalance <=0)
    }
    
    public void Withdraw(decimal amount)
    {
        
    }
}