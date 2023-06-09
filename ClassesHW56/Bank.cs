using HW456.ClassesHw56.Accounts;

namespace HW456.ClassesHw56;

class Bank
{
    public static void Transaction(BankAccount firstAccount, BankAccount secondAccount, decimal sum)
    {
        try
        {
            firstAccount.DecreaseBalance(sum);
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("Operation is not available");
        }
        
        try
        {
            secondAccount.IncreaseBalance(sum);
        }
        catch (Exception e)
        {
            firstAccount.IncreaseBalance(sum);
            throw new InvalidOperationException("Operation is not available");
        }
    }
}