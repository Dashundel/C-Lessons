namespace HW456;

public abstract class Client
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

    public decimal TotalBalance { get; } 

    public virtual string Info
    {
        get
        {
            return Id + '\n' + Phone + '\n' + OrderSum.ToString() + "руб" + '\n'; 
        }
    }
}