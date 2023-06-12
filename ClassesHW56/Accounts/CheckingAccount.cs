namespace HW456.ClassesHw56.Accounts;

class CheckingAccount : BankAccount
{
    public decimal ServiceCharge { get;}

    public void ApplyServiceCharge()
    {
        DecreaseBalance(ServiceCharge);
    }

    public CheckingAccount(decimal serviceCharge, string accountNumber, decimal balance, string ownerName):base(accountNumber, balance, ownerName)
    {
        ServiceCharge = serviceCharge;
    }
}