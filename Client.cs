namespace HW456;

public class Client
{
    /// <summary>
    /// Реализовать классы для описания клиентов двух типов: ИП и ООО.
    /// Каждый тип клиента имеет идентификатор, основной телефон, сумма заказа.
    /// У ИП указывается ФИО, дата рождения. У ООО указывается название, банковский счет.
    /// Реализовать метод, который возвращает отформатированное название и сумму заказа.
    /// </summary>

    public int id;
    public string phone;
    public int orderSum;

    public virtual string Info
    {
        get
        {
            return id + '\n' + phone + '\n' + orderSum.ToString() + "руб" + '\n'; 
        }
        
    }

    public static void func()
    {
        IE ieClient = new IE();
        LlC llCClient = new LlC();
      
        ieClient.id = 65482631;
        ieClient.phone = "+7(499)568945";
        ieClient.orderSum = 512;
        ieClient.date = DateOnly.FromDateTime(DateTime.Now.AddYears(-30));
        ieClient.name = "Блабла Бла Бла";
        Console.WriteLine(ieClient.Info);
      
        llCClient.id = 65482631;
        llCClient.phone = "+7(499)568945";
        llCClient.orderSum = 512;
        llCClient.name = "Ромашка";
        llCClient.bankAccount = 5555555555556666;
        Console.WriteLine(llCClient.Info);     
    }
}

public class IE: Client
{
    public string name;
    public DateOnly date;
    
    public override string Info
    {
        get { return name + '\n' + date.ToString() + '\n' + base.Info; }
    }
}
    
public class LlC: Client
{
    public string name;
    public long bankAccount;
    
    public override string Info
    {
        get { return name + '\n' + bankAccount.ToString() + '\n' + base.Info; }
    }
}