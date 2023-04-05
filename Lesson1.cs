public class Lesson1
{
    public static void Tasks_Lesson1()
    {
//Ввести с консоли 2 числа. Вывести их сумму на консоль
        Console.WriteLine("Input first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);

//Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n
        Console.WriteLine("Input number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input number i: ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((n >> i) & 1u);

//Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль
        Console.WriteLine("Input number n: ");
        int с = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((с >> 1) << 1);
    }
}