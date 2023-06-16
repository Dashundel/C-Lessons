using HW456.ClassesHw56.Accounts;

namespace Tests;

/// <summary>
/// Написать тест на пополнение счета.
/// </summary>

public class Tests
{
    [Test]
    public void IncreaseBalanceSuccses()
    {
        BankAccount saving = new BankAccount("12121", 101010,"Ivanov");

        saving.IncreaseBalance(200);
        decimal result = saving.Balance;

        Assert.AreEqual(300, Math.Abs(result));
    }
}
