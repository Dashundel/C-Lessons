using HW456.Lesson_10;
using HW456.Lesson_11;
using HW456.Lesson_12;
using HW456.Lesson_13;

namespace HW456;

class MainClass
{
    static void Main()
    {
        Lesson11.TaskLesson11();
        HW11.Task();
        
        Lesson12.Task();
        HW12.Task();

        Lesson13.Task();

        Console.ReadLine();
    }
    
    public static void Func()
    {
        var individualEntrepreneurClient = new IndividualEntrepreneur
        {
            Id = 65482631,
            Phone = "+7(499)568945",
            OrderSum = 512,
            Date = DateOnly.FromDateTime(DateTime.Now.AddYears(-30)),
            Name = "Блабла Бла Бла",
        };
        
        Console.WriteLine(individualEntrepreneurClient.Info);

        var limitedLiabilityCompanyClient = new LimitedLiabilityCompany
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