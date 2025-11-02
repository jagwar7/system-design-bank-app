

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

/* NOTE: SOLID PRINCIPLES IN BANK ACCOUNT SYSTEM
 * =====================================================================================================
 *
 * 1. INTERFACE IMPLEMENTATION (INDIRECT ACCESS)
 *    All subclasses of BankAccount indirectly implement IAccount via inheritance.
 *
 *       IAccount ◄──────────────── BankAccount ◄───────────────── SavingsAccount
 *       IAccount ◄──────────────── BankAccount ◄───────────────── CurrentAccount
 *
 *       → IAccount: Contract (what an account must provide)
 *       → BankAccount: Base implementation (shared state + deposit)
 *       → Subclasses: Specific behavior
 *
 * =====================================================================================================
 *
 * 2. SINGLE RESPONSIBILITY PRINCIPLE (SRP)
 *    Each class/interface has ONE reason to change:
 *
 *       • IAccount          → Define account identity (holder + balance)
 *       • BankAccount       → Shared state & basic deposit logic
 *       • SavingsAccount    → Min balance + interest rules
 *       • CurrentAccount    → Overdraft rules
 *
 * =====================================================================================================
 *
 * 3. OPEN/CLOSED PRINCIPLE (OCP)
 *    BankAccount is OPEN for EXTENSION, CLOSED for MODIFICATION.
 *
 *       SavingsAccount  ──INHERITS──► BankAccount  ← No changes to BankAccount
 *       CurrentAccount  ──INHERITS──► BankAccount  ← No changes to BankAccount
 *
 *       → Add new account types without touching existing code
 *
 * =====================================================================================================
 *
 * 4. LISKOV SUBSTITUTION PRINCIPLE (LSP)
 *    Any IAccount can be replaced with a concrete type without breaking behavior.
 *
 *       IAccount savings = new SavingsAccount("ZAIRA WASIM", 1000);  // Works
 *       IAccount current = new CurrentAccount("ZAIRA WASIM", 1000);  // Works
 *
 *       → Client code using IAccount works with ANY implementation
 *
 * =====================================================================================================
 *
 * 5. KEY DESIGN INSIGHT: WHY List<IAccount>?
 *
 *       List<IAccount> accounts = new List<IAccount>();
 *
 *       → SECURE & CONTROLLED ACCESS:
 *           account.GetBalance();     // Allowed (in IAccount)
 *           account.AccountHolder;    // Allowed
 *
 *           account.Withdraw(1000);   // COMPILE ERROR! (not in IAccount)
 *
 *       → IAccount acts as a SECURITY GATE:
 *           • Only safe operations (read name/balance) are exposed
 *           • Dangerous operations (withdraw, apply interest) are hidden
 *
 *       → This is INTERFACE SEGREGATION + ENCAPSULATION in action
 *
 * =====================================================================================================
 * CONCLUSION:
 *     • Polymorphic, secure, extensible, maintainable
 *     • Ready for real-world banking systems
 *     • Follows ALL SOLID principles
 */