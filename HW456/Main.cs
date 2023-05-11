// See https://aka.ms/new-console-template for more information

public class MainClass
{
    static void Main()
    {
        Lesson4.Telephone ph = new Lesson4.Telephone(0,"555666887");
        Console.WriteLine(ph.PhoneNumberWithoutCode());
        
        Lesson5.func();
        
        
        ///////////////////
        BaseClient client = new BaseClient();
        BaseClient client2 = new BaseClient();
        StandartClient standart = new StandartClient();
        StandartClient standart2 = new StandartClient();
        standart.AddAccount(new CheckingAccount(12, "2322000", 100));
        standart.AddAccount(new MetalAccount("Au", 12, 25, "4040000"));
        standart2.AddAccount(new CheckingAccount(12, "1331000", 500));
        Console.WriteLine($"Общая сумма: {client.TotalBalace}");
        standart.AccountList();
        standart2.AccountList();
        standart.CompareTo(standart);
        client.AccountList();

        BaseClient[] compare = new BaseClient[] { standart, standart2 };
        Array.Sort(compare);

        for (int i = 0; i < compare.Length; i++)
        {
            Console.WriteLine(compare[i].TotalBalace);
        }

        SavingsAccount saving = new SavingsAccount("2332432", 100);
        client.CloseAccount("0001");

    }
}