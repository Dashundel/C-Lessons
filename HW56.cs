using HW456.ClassesHw56.Accounts;

namespace HW456;

public abstract class HW56
{
   static public void Task()
   {
      //HW56
      ClassesHw56.Clients.SimpleBankClient simpleBankClient = new ClassesHw56.Clients.SimpleBankClient();
      simpleBankClient.AddAccount(new CheckingAccount(100, "00001", 10000, nameof(simpleBankClient)));
      simpleBankClient.AddAccount(new SavingAccount(2000, 5, "00002",10000, nameof(simpleBankClient)));
      Console.WriteLine($"Simple client: \n{simpleBankClient.TotalBalance}");
        
      ClassesHw56.Clients.VipBankClient vipBankClient = new ClassesHw56.Clients.VipBankClient();
      vipBankClient.AddAccount(new MetalAccount("Au", 12, 25, "00003", nameof(vipBankClient)));
      vipBankClient.AddAccount(new CheckingAccount(2000, "00004", 50000, nameof(vipBankClient)));
      Console.WriteLine($"Vip client: \n{vipBankClient.TotalBalance}");
       
      vipBankClient.CloseAccount("00003");
      Console.WriteLine($"Vip client after closing account: \n {vipBankClient.TotalBalance}");
        
      simpleBankClient.PrintAccountList();
      vipBankClient.PrintAccountList();
        
      var compareTo = simpleBankClient.CompareTo(vipBankClient);
        
      if (compareTo == 1)
      {
         Console.WriteLine("Simple client Total Balace is bigger than vip client"); 
      }
      else if(compareTo == -1)
      {
         Console.WriteLine("Vip client Total Balace is bigger than vip client"); 
      }
      else
      {
         Console.WriteLine("Something's wrong!"); 
      }
   }
}