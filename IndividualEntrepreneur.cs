namespace HW456;
public class IndividualEntrepreneur: Client
{
    public string? Name;
    public DateOnly Date;
    
    public override string Info
    {
        get { return Name + '\n' + Date.ToString() + '\n' + base.Info; }
    }
}