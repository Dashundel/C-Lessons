namespace HW456.ClassesHw56.Accounts;

public class IncreaseAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public virtual decimal Balance { get; set; }
    public bool IsActive { get; set; }

    public virtual bool IncreaseBalance(decimal sum)
    {
        if (sum < 0)
        {
           throw new ArgumentOutOfRangeException("sum", "The amount of increasing must be positive"); 
        }
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
                throw new ArgumentOutOfRangeException("amount", "The amount of decreasing is bigger then the balance");
            }
            else
            {
                Balance -= sum;
            }
        }
        else
        {
           throw new InvalidOperationException("Operation is not available");
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
                throw new ArgumentOutOfRangeException("Balance", "It's bad idea, you have positive balance.");
            }
        }
        else
        {
            throw new InvalidOperationException("Operation is not available");
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
