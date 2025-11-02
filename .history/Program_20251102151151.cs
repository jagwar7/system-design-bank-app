

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



    SINGLE RESPONSIBILITY:              EACH CLASS AND INTERFACE IS FOR A PRTICULAR REQUIREMENT
        IAccount:                           Define what an account is (holder + balance)
        BankAccount:                        Shared state & basic deposit
        SavingsAccount:                     Savings rules (min balance, interest)
        CurrentAccount:                     Current rules (overdraft)


    OPEN CLOSED PRINCIPLE:              BANKACCOUNT IS OPEN FOR EXTENSION BUT CLOSED FOR MODIFICATION
        SavingsAccount --------INHERITS-----> BankAccount ,  Without chaing BankAccout's code
        CurrentAccount --------INHERITS-----> BankAccount ,  Without chaing BankAccout's code


    LISKOV SUBTITUTION PRINCIPLE:       CAN REPLACE ANY ACCOUNT TYPE BY IAccount
        IAccount savingsAccount = new SavingsAccount("ZAIRA WASIM", 1000);
        IAccount currentAccount = new CurrentAccount("ZAIRA WASIM", 1000);


    KEY LEARNINGS: 
        Why this list type is IAccount here : List<IAccount> list = new List<IAccount>();

        The type IAccount will pass a sercure list where only Names and Balnaces are can be fetched. 
            ONLY NAME AND BALANCES are readable:
                foreach(IAccount account in list)
            No other methods can be called of SavingsAccount or CurrentAccount;
            
        
        
*/ //----------------------------------------------------------------------------------------------------------


