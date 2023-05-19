using HW456.HW5.Accounts;

namespace HW456.HW5.Clients;

class Client
{
    protected List<IncreaseAccount> Accounts { get; set; }
    protected int AccountsCount { get; set; }

    public Client()
    {
        Accounts = new List<IncreaseAccount>();
    }

    public decimal TotalBalace
    {
        get
        {
            decimal sum = 0;

            for (int i = 0; i < Accounts.Count; i++)
            {
                sum += Accounts[i].Balance;
            }

            return sum;
        }
    }

    public void PrintAccountList()
    {
        for (int i = 0; i < Accounts.Count; i++)
        {
            Console.WriteLine($"Account: {Accounts[i].AccountNumber} + Balance: {Accounts[i].Balance}");
        }
    }

    public virtual void AddAccount(IncreaseAccount account)
    {
        if (Accounts.Count <= AccountsCount)
        {
            Accounts.Add(account);
        }
        else
        {
            Console.WriteLine("Too much accounts!");
        }
    }

    public void CloseAccount(string accountNumber)
    {
        //IncreaseAccount account = null;

        for (int i = 0; i < Accounts.Count; i++)
        {
            if (Accounts[i].AccountNumber == accountNumber)
            {
                Accounts.RemoveAt(i);
                //account = Accounts[i];
                //break;
            }
        }
    }
} 
