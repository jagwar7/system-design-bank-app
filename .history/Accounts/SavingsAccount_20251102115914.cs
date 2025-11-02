

public class SavingsAccount : BankAccount, IWithdrawable, IInterestApplicable
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

        if (Balance - amount < minBalance)
        {
            Console.WriteLine($"Cannot withdraw, Minimum balance : {minBalance} is required");
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawn amount: {amount}, Available Balance: {Balance}");
    }
    
    public void ApplyInterest()
    {
        decimal rate = 5m;
        Balance += (Balance * rate) / 100;
        Console.WriteLine($"Interest Applied:{rate} , Total")
    }
}