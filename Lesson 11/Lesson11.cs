namespace HW456.Lesson_11;

/// <summary>
/// Написать метод-расширение для массива целых чисел, который выводит этот массив на консоль.
/// </summary>

public static class Lesson11
{
    public static void TaskLesson11()
    {
        int[] intArray = GenerateArray();
        intArray.PrintArray();
    }
    public static int[] GenerateArray()
    {
        Random rnd = new Random();
        var n = rnd.Next(10);
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(100);
        }

        return arr;
    }
    public static void PrintArray(this int[] arr)
    {
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
    
}