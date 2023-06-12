namespace HW456.ClassesHw56.Accounts;

class SavingAccount : BankAccount
{
    public decimal InitialDeposit { get; set; }
    public decimal Rate { get; set; }

    public override bool DecreaseBalance(decimal amount)
    {
        DecreaseBalance(amount);
        
        if (amount >= InitialDeposit)
        {
            base.DecreaseBalance(amount);
            return true;
        }
        else
        {
            throw new ArgumentOutOfRangeException("amount","The amount is bigger than initial deposit");
        }
    }
    
    public void Capitalization()
    {
        if (IsActive)
        {
            IncreaseBalance(Balance * ((Rate / 12) / 100));
        }
        else
        {
            throw new InvalidOperationException("Operation is not available");
        }
    }

    public SavingAccount(decimal initialDeposit, decimal rate, string accountNumber, decimal balance, string ownerName) : base(accountNumber, balance, ownerName)
    {
        InitialDeposit = initialDeposit;
        Rate = rate;
    }

} 
