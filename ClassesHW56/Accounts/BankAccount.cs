namespace HW456.ClassesHw56.Accounts;

public class BankAccount
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
        
        if (!IsActive)
        {
            throw new InvalidOperationException("Operation is not available");
        }
        
        Balance += sum;
        return true;
    }
    public virtual bool DecreaseBalance(decimal sum)
    {
        if (!IsActive)
        {
            throw new InvalidOperationException("Operation is not available");
        }
        
        if (sum > Balance)
        {
            throw new ArgumentOutOfRangeException("sum", "The amount of decreasing is bigger then the balance");
        }
        
        Balance -= sum;
        return true;
    }

    public void CloseAccount()
    {
        if (!IsActive)
        {
            throw new InvalidOperationException("Operation is not available");
        }
        
        if (Balance < 0)
        {
            throw new ArgumentOutOfRangeException("Balance", "It's bad idea, you have positive balance.");
        }
        IsActive = false; 
    }

    public BankAccount(string accountNumber, decimal balance, string ownerName) : this(accountNumber, ownerName)
    {
        Balance = balance;
    }

    public BankAccount(string accountNumber, string ownerName)
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
