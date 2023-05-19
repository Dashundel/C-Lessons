namespace HW456.HW5.Accounts;

public class IncreaseAccount
{
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public virtual decimal Balance { get; set; }
    public bool IsActive { get; set; }

    public virtual bool IncreaseBalance(decimal sum)
    {
        if (IsActive)
        {
            Balance += sum;
            return true;
        }
        else
        {
            Console.WriteLine("Operation is not available");
            return false;
        }
    }
    public virtual void DecreaseBalance(decimal sum)
    {
        if (IsActive)
        {
            if (sum > Balance)
            {
                Console.WriteLine("The amount of decreasing is bigger then the balance");
            }

            else
            {
                Balance -= sum;
            }

        }
        else
        {
            Console.WriteLine("Operation is not available");
        }
    }

    public void CloseAccount()
    {
        if (IsActive)
        {
            if (Balance == 0)
            {
                IsActive = false;
            }
            else
            {
                Console.WriteLine("It's bad idea, you have positive balance.");
            }
        }
        else
        {
            Console.WriteLine("Operation is not available");
        }
    }

    public IncreaseAccount(string accountNumber, decimal balance, string ownerName) : this(accountNumber, ownerName)
    {
        Balance = balance;
    }

    public IncreaseAccount(string accountNumber, string ownerName)
    {
        IsActive = true;
        AccountNumber = accountNumber;
        OwnerName = ownerName;
    }

    public override string ToString()
    {
        return $"{Balance}";
    }
}
