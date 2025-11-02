

/* NOTE: ------------------------------------------------------------------------------------------------------
    To call the Funcions of SavingsAccount object type should be SavingsAccount, 
    SavingsAccount savingsAccount  = new SavingsAccount
*/ //----------------------------------------------------------------------------------------------------------
SavingsAccount savingsAccount = new SavingsAccount("jagwar", 1000);

Console.WriteLine(savingsAccount.GetBalance());

savingsAccount.Deposit(0);
Console.WriteLine(savingsAccount.GetBalance());

savingsAccount.Withdraw(500);
