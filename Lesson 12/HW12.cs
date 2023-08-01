namespace HW456.Lesson_12;

/// <summary>
/// Создать коллекцию из 100 случайных дробей.
/// Выбрать все дроби, которые являются целым числом.
/// Вывести на консоль их как целые числа.
/// </summary>

public class HW12
{
    public static void Task()
    {
        var list = GenerateListFractions();
       
        IEnumerable<Fraction> listInteger = list.Where(x => x.Numerals % x.Denominator == 0); 
        
        foreach (var n in listInteger)
            Console.WriteLine(n.Numerals / n.Denominator);
    }
    
    public static List<Fraction> GenerateListFractions()
    {
        Random rnd = new Random();
        var n = rnd.Next(20);
        var list = new List<Fraction>();

        for (int i = 0; i < n; i++)
        {
            list.Add(new Fraction() {Denominator = rnd.Next(100), Numerals = rnd.Next(100)}); 
            
        }

        foreach (var j in list)
        {
            Console.WriteLine(j.Numerals.ToString() + "/" + j.Denominator.ToString());
        }
        
        return list;
    }
}

public class Fraction 
{
    public int Numerals { get; set; }
    public int Denominator { get; set; }
}
