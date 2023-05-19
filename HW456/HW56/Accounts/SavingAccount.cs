using HW456.HW5.Accounts;

namespace HW456.HW5;


class SavingAccount : IncreaseAccount
{
    public decimal InitialDeposit { get; set; }
    public decimal Rate { get; set; }

    public override void DecreaseBalance(decimal amount)
    {
        /*if (amount >= InitialDeposit)
        {
            return base.DecreaseBalance(amount);
        }
        else
        {
            throw new ArgumentException("Сумма списания не может быть меньше первоначального взноса");
        }*/
        
        DecreaseBalance(amount);
        
        if (amount >= InitialDeposit)
        {
            base.DecreaseBalance(amount);
        }
        else
        {
            Console.WriteLine("The amount is bigger than initial deposit");
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
            Console.WriteLine("Operation is not available");
        }
    }

    public SavingAccount(decimal initialDeposit, decimal rate, string accountNumber, decimal balance, string ownerName) : base(accountNumber, balance, ownerName)
    {
        InitialDeposit = initialDeposit;
        Rate = rate;
    }

} 
