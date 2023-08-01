namespace HW456;

public class Client
{
    /// <summary>
    /// Реализовать классы для описания клиентов двух типов: ИП и ООО.
    /// Каждый тип клиента имеет идентификатор, основной телефон, сумма заказа.
    /// У ИП указывается ФИО, дата рождения. У ООО указывается название, банковский счет.
    /// Реализовать метод, который возвращает отформатированное название и сумму заказа.
    /// </summary>

    public int Id;
    public string? Phone;
    public int OrderSum;
  
    public virtual string Info
    {
        get
        {
            return Id + '\n' + Phone + '\n' + OrderSum.ToString() + "руб" + '\n'; 
        }
        
    }

    public static void Func()
    {
        Ie ieClient = new Ie();
        LlC llCClient = new LlC();
      
        ieClient.Id = 65482631;
        ieClient.Phone = "+7(499)568945";
        ieClient.OrderSum = 512;
        ieClient.Date = DateOnly.FromDateTime(DateTime.Now.AddYears(-30));
        ieClient.Name = "Блабла Бла Бла";
        Console.WriteLine(ieClient.Info);
      
        llCClient.Id = 65482631;
        llCClient.Phone = "+7(499)568945";
        llCClient.OrderSum = 512;
        llCClient.Name = "Ромашка";
        llCClient.BankAccount = 5555555555556666;
        Console.WriteLine(llCClient.Info);     
    }
}

public class Ie: Client
{
    public string? Name;
    public DateOnly Date;
    
    public override string Info
    {
        get { return Name + '\n' + Date.ToString() + '\n' + base.Info; }
    }
}
    
public class LlC: Client
{
    public string? Name;
    public long BankAccount;
    
    public override string Info
    {
        get { return Name + '\n' + BankAccount.ToString() + '\n' + base.Info; }
    }
}
