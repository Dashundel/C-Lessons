using System;
using System.Linq;

namespace ConsoleApp1;

public class HW3
{
    /*
     * Считать строку с консоли.
     * Создать словарь, где ключом будет символ строки,
     * а значением - количество данных символов в считанной строке.
     */
    public static void Task1_StrDictionary()
    {
        Console.WriteLine("Task1: ");
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        string str = Console.ReadLine();
        int count = 0;
        
        foreach (var i in str)
        {
            count = 0;
            int ind = str.IndexOf(i);
            while (ind >= 0)
            {
                ind = str.IndexOf(i, ind + 1);
                count++;
            }
            if(!dict.ContainsKey(i.ToString())) dict.Add(i.ToString(), count);
        }

        foreach (var i in dict)
        {
           Console.WriteLine(i); 
        }
        
        
    }
    
    /*
     * Считывать с консоли числа, пока не будет введено число “-1”,
     * среди введенных чисел вывести все дублирующиеся.
     */
    public static void Task2_DoublNumbers()
    {
        Console.WriteLine("Input numbers: ");
        int number = Convert.ToInt32(Console.ReadLine());
        List<int> list = new List<int>();
        
        while (number != -1)
        {   
            list.Add(number);
            Console.WriteLine("Input numbers: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Dublicates: ");
        
        for (var i = 0; i < list.Count; i++)
        {
            if (list.FindAll(j => j == i).Count() > 1)
            {
                Console.WriteLine(list[i]);
                list.RemoveAll(j => j == i);
            }
        }
    }
}