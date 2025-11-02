

public class SavingsAccount : BankAccount, IWithdrawable
{
    public SavingsAccount(string name, decimal intialBalance) : base(name, intialBalance)
    {

    }
    
    public void Withdraw(decimal amount)
    {
        
    }
}