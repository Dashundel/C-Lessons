using HW456.HW5.Accounts;

namespace HW456.HW5;

class Bank
{
    private static void Transaction(IncreaseAccount firstAccount, IncreaseAccount secondAccount, decimal sum)
    {
        firstAccount.DecreaseBalance(sum);
        secondAccount.IncreaseBalance(sum);
    }
}