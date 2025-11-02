

public class SavingsAccount : BankAccount, IWithdrawable
{
    public string AccountHolder;
    public decimal Balance;

    public SavingsAccount(string name, decimal balance) : base(name, balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if(Balance >= amount)
        {
            Console.WriteLine($"Withdrawn : {amount} , Availabe Balance: {Balance}");
        }
    }
}