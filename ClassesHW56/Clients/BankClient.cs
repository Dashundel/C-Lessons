using HW456.ClassesHw56.Accounts;

namespace HW456.ClassesHW56.Clients;

public class BankClient: IComparable
{
    protected List<BankAccount> Accounts { get; }

    public BankClient()
    {
        Accounts = new List<BankAccount>();
    }

    public decimal TotalBalance  => Accounts.Sum(x => x.Balance);

    public void PrintAccountList()
    {
        for (int i = 0; i < Accounts.Count; i++)
        {
            Console.WriteLine($"Account: {Accounts[i].AccountNumber}  Balance: {Accounts[i].Balance}");
        }
    }

    public virtual void AddAccount(BankAccount account)
    {
            Accounts.Add(account); 
    }

    public void CloseAccount(string accountNumber)
    {
        if (Accounts.Count >= Convert.ToInt32(accountNumber) && Convert.ToInt32(accountNumber) >= 0)
        {
            foreach (var i in Accounts)
            {
                if (i.AccountNumber == accountNumber)
                {
                    CloseAccount(i.AccountNumber);
                }
            }
        }
        else
        {
            throw new ArgumentException("Bad accountNumber"); 
        }
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1; 
        if (ReferenceEquals(this, obj)) return 0; 
        
        return obj is Client other 
            ? TotalBalance.CompareTo(other.TotalBalance) 
            : throw new ArgumentException($"Object must be of type {nameof(Client)}");
    }
}