namespace HW456;

/// <summary>
/// Реализовать неизменяемую структуру - простая дробь (x/y).
/// Числитель и знаменатель - целые числа. Знаменатель - всегда положительный.
/// Ноль - 0/x. Реализовать операции сложения, вычитания, умножения, деления.
/// Реализовать интерфейс IComparable.
/// Создать массив из N случайных дробей, отсортировать по возрастанию.
/// Найти сумму всех дробей.
/// *Сделать дробь не сокращаемой. Т.е. 2/4 -> 1/2, 50/15 -> 10/3, 0/7 -> 0/1 и т.д
/// </summary>
public class HW7
{
    public static void Task()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(2, 5);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(2, 15);
        SimpleFractionStructure subtractResult = SimpleFractionStructure.Subtract(firstFraction, secondFraction);
        SimpleFractionStructure multiplyResult = SimpleFractionStructure.Multiply(firstFraction, secondFraction);
        SimpleFractionStructure divisiveResult = SimpleFractionStructure.Divisive(firstFraction, secondFraction);

        Console.WriteLine($"{firstFraction.Numerator.ToString()+"/"+firstFraction.Denominator.ToString()} - " +
                          $"{secondFraction.Numerator.ToString()+"/"+secondFraction.Denominator.ToString()} = " +
                          $"{subtractResult.Numerator.ToString()+"/"+subtractResult.Denominator.ToString()}");
        
        Console.WriteLine($"{firstFraction.Numerator.ToString()+"/"+firstFraction.Denominator.ToString()} * " +
                          $"{secondFraction.Numerator.ToString()+"/"+secondFraction.Denominator.ToString()} = " +
                          $"{multiplyResult.Numerator.ToString()+"/"+multiplyResult.Denominator.ToString()}");
        
        Console.WriteLine($"{firstFraction.Numerator.ToString()+"/"+firstFraction.Denominator.ToString()} : " +
                          $"{secondFraction.Numerator.ToString()+"/"+secondFraction.Denominator.ToString()} = " +
                          $"{divisiveResult.Numerator.ToString()+"/"+divisiveResult.Denominator.ToString()}");

        SimpleFractionStructure[] compare = new SimpleFractionStructure[5];
        Random rand = new Random();

        for (int i = 0; i < compare.Length; i++)
        {
            compare[i] = new SimpleFractionStructure(rand.Next(10), rand.Next(15));
        }

        Array.Sort(compare);

        for (int i = 0; i < compare.Length; i++)
        {
            Console.WriteLine(compare[i].Numerator.ToString()+"/"+compare[i].Denominator.ToString());
        }
        Console.ReadLine();
    }

}