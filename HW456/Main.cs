namespace HW456;

class MainClass
{
    static void Main()
    {
        Lesson4.Telephone ph = new Lesson4.Telephone(0,"555666887");
        Console.WriteLine(ph.PhoneNumberWithoutCode());
        
        Client.Func();
        
        HW56.Task(); 
        HW7.Task();
        
        Console.ReadLine();

    }
}