using HW456.HW5.Accounts;

namespace HW456.HW5;

class CheckingAccount : IncreaseAccount
{
    public decimal ServiceCharge { get; private set; }

    public void ApplyServiceCharge()
    {
        DecreaseBalance(ServiceCharge);
    }

    public CheckingAccount(decimal serviceCharge, string accountNumber, decimal balance, string ownerName):base(accountNumber, balance, ownerName)
    {
        ServiceCharge = serviceCharge;
    }
}