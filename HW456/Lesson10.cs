namespace HW456.Lesson_10;

/// <summary>
/// Ввести с консоли N чисел, записать их в файл. 
/// Считать числа из файла, вывести на консоль. 
/// Сделать любым способом
/// </summary>

public class Lesson10
{
    public static void Numbers()
    {
        Console.WriteLine("Input amount for numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Input number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        WriteNumbers(numbers);
        ReadNumbers();
    }
    
    public static void WriteNumbers(int[] numbers)
    {
        StreamWriter sw = new StreamWriter("C:/Users/d.lazareva/RiderProjects/HW456/HW456/Lesson 10/numbers.txt");
        foreach (var i in numbers)
        {
            sw.WriteLine(i);
        }
        sw.Close();
        
        Console.WriteLine("The Numbers are written");
    }
    public static void ReadNumbers()
    {
        StreamReader sr = new StreamReader("C:/Users/d.lazareva/RiderProjects/HW456/HW456/Lesson 10/numbers.txt");
        string? line;
        
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
        sr.Close(); 
    }
}