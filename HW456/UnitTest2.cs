using HW456.ClassesHw56.Accounts;

namespace Tests;

public class UnitTest2
{
    [Test]
    public void DecreaseBalanceSuccses()
    {
        BankAccount saving = new BankAccount("12121", 20000, "Perov");

        saving.DecreaseBalance(150);
        decimal result = saving.Balance;

        Assert.AreEqual(19850, Math.Abs(result));
    }
    
    [Test] 
    public void DecreaseBalanceFailed()
    {
        var balance = 3550;
        BankAccount saving = new BankAccount("12121", balance,"Tarasov");
        Assert.False(saving.DecreaseBalance(3550));
    }
}