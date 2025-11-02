
public class CurrentAccount : BankAccount, IWithdrawable
{
    private const decimal overdraftLimit = 1000m;

    public CurrentAccount(string name, decimal initalBalance = 0) : base(name, initalBalance)
    {

    }
    
    public void Withdraw(decimal amount)
    {
        if(amount < 0)
        {
            Console.WriteLine($"")
        }
    }
}