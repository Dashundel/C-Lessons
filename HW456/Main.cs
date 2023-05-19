using HW456.HW5;
using HW456.HW5.Clients;

public class MainClass
{
    static void Main()
    {
        Lesson4.Telephone ph = new Lesson4.Telephone(0,"555666887");
        Console.WriteLine(ph.PhoneNumberWithoutCode());
        
        Client.func();
        
        //HW56
        SimpleClient simpleClient = new SimpleClient();
        simpleClient.AddAccount(new CheckingAccount(100, "00001", 10000, nameof(simpleClient)));
        simpleClient.AddAccount(new SavingAccount(2000, 5, "00002",10000, nameof(simpleClient)));
        Console.WriteLine($"Simple client: \n{simpleClient.TotalBalace.ToString()}");
        
        VipClient vipClient = new VipClient();
        vipClient.AddAccount(new MetalAccount("Au", 12, 25, "00003", nameof(vipClient)));
        vipClient.AddAccount(new CheckingAccount(2000, "00004", 50000, nameof(vipClient)));
        Console.WriteLine($"Vip client: \n{vipClient.TotalBalace}");
       
        vipClient.CloseAccount("00003");
        Console.WriteLine($"Vip client after closing account: \n {vipClient.TotalBalace}");

    }
}