namespace HW456.ClassesHw56.Accounts;

class MetalAccount : IncreaseAccount
{
    public string MetalType { get;}
    public decimal MetalWeight { get; set;}
    public decimal MetalPrice { get;}

    public override decimal Balance
    {
        get
        {
            return MetalPrice * MetalWeight;
        }
    }

    public override bool IncreaseBalance(decimal amount)
    {
        if (base.IncreaseBalance(amount))
        {
            MetalWeight = MetalWeight + amount / MetalPrice;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void DecreaseBalance(decimal amount)
    {
        base.DecreaseBalance(amount);
        if (amount <= Balance)
        {
            MetalWeight -= amount / MetalPrice;
        }
    }

    public MetalAccount(string metalType, decimal metalWeight, decimal metalPrice, string accountNumber, string ownerName) : base(accountNumber, ownerName)
    {
        MetalPrice = metalPrice;
        MetalType = metalType;
        MetalWeight = metalWeight;
    }
}