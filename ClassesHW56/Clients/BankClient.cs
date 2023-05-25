using HW456.ClassesHw56.Accounts;

class BankClient: IComparable
{
    protected List<IncreaseAccount> Accounts { get; set; }
    protected int AccountsCount { get; set; }

    public BankClient()
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
            Console.WriteLine($"Account: {Accounts[i].AccountNumber}  Balance: {Accounts[i].Balance}");
        }
    }

    public virtual void AddAccount(IncreaseAccount account)
    {
        /*if (Accounts.Count <= AccountsCount)
        {
            Accounts.Add(account);
        }
        else
        {
            Console.WriteLine("Too much accounts!");
        }*/
        try
        {
            Accounts.Add(account);
        }
        catch (InvalidDataException ex) when(Accounts.Count > AccountsCount)
        {
            Console.WriteLine("Too much accounts!");
        }
    }

    public void CloseAccount(string accountNumber)
    {
        for (int i = 0; i < Accounts.Count; i++)
        {
            if (Accounts[i].AccountNumber == accountNumber)
            {
                Accounts.RemoveAt(i);
            }
        }
    }
    
    public int CompareTo(object obj)
    {
        BankClient bankClient = (BankClient)obj;
        if (TotalBalace > bankClient.TotalBalace)
            return 1;
        if (TotalBalace < bankClient.TotalBalace)
            return -1;

        return 0;
    }
} 
