using HW456.ClassesHw56.Accounts;
using HW456.ClassesHW56.Clients;

namespace HW456.ClassesHw56.Clients;

class SimpleBankClient : BankClient
{
    protected int AccountsLimit { get; }
    public SimpleBankClient()
    {
        AccountsLimit = 3;
    }
    public override void AddAccount(BankAccount account)
    {
         if (Accounts.Count >= AccountsLimit)
         {
            throw new InvalidOperationException("Too much accounts!"); 
         }
         else
         {
            Accounts.Add(account); 
         }
    }
}