namespace HW456.HW5.Clients;

class VipClient: Client
{
    public VipClient()
    {
        AccountsCount = 10;
    } 
}

class SimpleClient : Client
{
    public SimpleClient()
    {
        AccountsCount = 3;
    }
}