using HW456.ClassesHw56.Accounts;
using HW456.ClassesHW56.Clients;

namespace HW456.ClassesHw56.Clients;

class VipBankClient: BankClient
{
    protected int AccountsLimit { get; }
    public VipBankClient()
    {
        AccountsLimit = 10;
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