namespace HW456.Lesson_11;

/// <summary>
/// Написать метод-расширение для массива целых чисел, который принимает как параметр строку-разделитель,
/// а возвращает строку, в которая содержатся все элементы массива перечисленные через указанный разделитель.
/// </summary>

public static class HW11
{
    public static void Task()
    {
        Console.WriteLine("Input splitter: ");
        string splitter = Console.ReadLine();

        int[] array = Lesson11.GenerateArray();
        
        Console.WriteLine(splitter.ArrayWithSplitter(array));
    }
    public static string ArrayWithSplitter(this string splitter, int[] arr)
    {
        var numbersWithSplitter = String.Empty;

        foreach (var i in arr)
        {
            numbersWithSplitter = numbersWithSplitter + i.ToString() + splitter;
        }

        return numbersWithSplitter.TrimEnd(Convert.ToChar(splitter));
    }
}