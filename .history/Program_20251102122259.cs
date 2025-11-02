

/* NOTE: ------------------------------------------------------------------------------------------------------
    To call the Funcions of SavingsAccount object type should be SavingsAccount, 
    BankAccount savingsAccount  = new SavingsAccount("jagwar", 1000);
    savingsAccount.Withdraw(500);  ❌  Withdraw function is not a property of BankAccount class
    
    SavingsAccount savingsAccount  = new SavingsAccount("jagwar", 1000);
    savingsAccount.Withdraw(500);  ✅  Withdraw function is a property of SavingsAccount class

    LEARNINGS: 
        1: If OBJECT type is BankAccount ---> Only BankAccount class's methods are accessible

        2: If OBJECT type is SavingsAccount ---> BankAccount + SavingsAccount class's methods are accessible
*/ //----------------------------------------------------------------------------------------------------------




List<IAccount> list = new List<IAccount>();
list.Add(new SavingsAccount("Jagwar", 4000m));