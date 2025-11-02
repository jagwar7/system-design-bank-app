

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
list.Add(new SavingsAccount("Zaira", 4500m));
list.Add(new CurrentAccount("JagwarSavings", 5000m));

foreach (IAccount account in list)
{
    Console.WriteLine($"Name: {account.AccountHolder}, Balance: {account.GetBalance()}");
}


/* NOTE: ------------------------------------------------------------------------------------------------------
    All the subclasses of BankAccount class are indirectly Accessing IAccount interface. Example below.


      ------INTERFACE---- direct access by -------BASE CLASSS----- accessed by -------SUB CLASS----------------

      ------IAccount <--------------------------- BankAccount <------------------ SavingsAccount---------------
      ------IAccount <--------------------------- BankAccount <------------------ CurrentAccount---------------
    
      ------INTERFACE --------------------- INDIRECT ACCESS BY --------------------SUB CLASS-------------------



    SINGLE RESPONSIBILITY: EACH CLASS AND INTERFACE IS FOR A PRTICULAR REQUIREMENT
        IAccount:               Define what an account is (holder + balance)
        BankAccount:            Shared state & basic deposit
        SavingsAccount:         Savings rules (min balance, interest)
        CurrentAccount:         Current rules (overdraft)


    OPEN CLOSED PRINCIPLE: BANK IS OPEN F
        
*/ //----------------------------------------------------------------------------------------------------------


