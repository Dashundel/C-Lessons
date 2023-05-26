using HW456.ClassesHw56.Accounts;

namespace HW456.ClassesHw56;

class Bank
{
    private static void Transaction(IncreaseAccount firstAccount, IncreaseAccount secondAccount, decimal sum)
    {
        firstAccount.DecreaseBalance(sum);
        secondAccount.IncreaseBalance(sum);
    }
}