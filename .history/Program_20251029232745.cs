

/* NOTE: ------------------------------------------------------------------------------------------------------
    To call the Funcions of SavingsAccount object type should be SavingsAccount, 
    BankAccount savingsAccount  = new SavingsAccount("jagwar", 1000);
    savingsAccount.Withdraw(500);  ❌  Withdraw function is not a property of BankAccount class
    
    SavingsAccount savingsAccount  = new SavingsAccount("jagwar", 1000);
    savingsAccount.Withdraw(500);  ✅  Withdraw function is a property of SavingsAccount class

    LEARNINGS: 
        1: If OBJECT type is BankAccount ---> Only BankAccount 
*/ //----------------------------------------------------------------------------------------------------------
SavingsAccount savingsAccount = new SavingsAccount("jagwar", 1000);

Console.WriteLine(savingsAccount.GetBalance());

savingsAccount.Deposit(0);
Console.WriteLine(savingsAccount.GetBalance());

savingsAccount.Withdraw(500);
