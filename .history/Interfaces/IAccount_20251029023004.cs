public interface IAccount
{
    string AccountHolder{ get; protected set; }
    decimal GetBalance();
}