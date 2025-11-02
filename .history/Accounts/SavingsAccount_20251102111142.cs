

public class SavingsAccount : BankAccount, IWithdrawable
{
    public SavingsAccount(string name, decimal intialBalance) : base(name, intialBalance)
    {
        
    }
}