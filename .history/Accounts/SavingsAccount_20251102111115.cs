

public class SavingsAccount : BankAccount, IWithdrawable
{
    public SavingsAccount(string name, decimal balance) : base(name, balance)
}