namespace HW456;

public class LimitedLiabilityCompany: Client
{
    public string? Name;
    public long BankAccount;
    
    public override string Info
    {
        get { return Name + '\n' + BankAccount.ToString() + '\n' + base.Info; }
    }
}