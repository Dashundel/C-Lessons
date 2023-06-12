using HW456.ClassesHW56.Clients;

namespace HW456.ClassesHw56.Clients;

class VipBankClient: BankClient
{
    public VipBankClient()
    {
        AccountsCount = 10;
    } 
}

class SimpleBankClient : BankClient
{
    public SimpleBankClient()
    {
        AccountsCount = 3;
    }
}