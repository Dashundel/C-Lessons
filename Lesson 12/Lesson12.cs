namespace HW456.Lesson_12;

/// <summary>
/// Создать массив из 10 числе.
/// Вывести на экран с помощью LINQ только четные или те, что больше 5.
/// Отсортировать по убыванию.
/// </summary>

public class Lesson12
{
    public static void Task()
    {
        int[] array = GenerateArray();
        IEnumerable<int> filterNumbers = 
            from a in array
            where a % 2 == 0 || a > 5
            orderby a descending 
            select a;
        
        foreach (int i in filterNumbers)
        {
            Console.WriteLine(i);
        }
    }
    
    public static int[] GenerateArray()
    {
        Random rnd = new Random();
        var n = 10;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(100);
        }

        return arr;
    }
}