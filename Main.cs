namespace HW456;

class MainClass
{
    static void Main()
    {
        Lesson4.Telephone ph = new Lesson4.Telephone(0,"555666887");
        Console.WriteLine(ph.PhoneNumberWithoutCode());
        
        Func();
        
        HW56.Task(); 
        HW7.Task();
        
        Console.ReadLine();

    }
    
    public static void Func()
    {
        IndividualEntrepreneur individualEntrepreneurClient = new IndividualEntrepreneur()
        {
            Id = 65482631,
            Phone = "+7(499)568945",
            OrderSum = 512,
            Date = DateOnly.FromDateTime(DateTime.Now.AddYears(-30)),
            Name = "Блабла Бла Бла",
        };
        Console.WriteLine(individualEntrepreneurClient.Info);

        LimitedLiabilityCompany limitedLiabilityCompanyClient = new LimitedLiabilityCompany()
        {
            Id = 65482631,
            Phone = "+7(499)568945",
            OrderSum = 512,
            Name = "Ромашка",
            BankAccount = 5555555555556666,
        }; 
        Console.WriteLine(limitedLiabilityCompanyClient.Info);
    }
}