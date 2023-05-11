using System;
using System.Linq;

namespace ConsoleApp1;

public class HW3
{
    /// <summary>
    /// Считать строку с консоли.Создать словарь,
    /// где ключом будет символ строки,
    /// а значением - количество данных символов в считанной строке. 
    /// </summary>
   
    public static void Task1_StrDictionary()
    {
        Console.WriteLine("Task1: ");
        
        Dictionary<Char,int> symbolCountDictionary = new Dictionary<Char,int>();
        
        string input = Console.ReadLine();
        
        for (int i = 0; i < input.Length; i++)
        {
            char character = input[i];
            if (symbolCountDictionary.ContainsKey(character))
                symbolCountDictionary[character] = symbolCountDictionary[character] + 1;
            else
                symbolCountDictionary.Add(character, 1);
        }
       
        foreach (var i in symbolCountDictionary)
        {
           Console.WriteLine(i); 
        }
        
        
    }
    /// <summary>
    /// Считывать с консоли числа, пока не будет введено число “-2”,
    /// среди введенных чисел вывести все дублирующиеся.
    /// </summary>
    public static void Task2_DuplicateNumbers()
    {
        Console.WriteLine("Input numbers: ");
        Dictionary<int, int> symbolCountDictionary = new Dictionary<int, int>();
       
        int input = Convert.ToInt32(Console.ReadLine());

        while (input != -2)
        {
            if (symbolCountDictionary.ContainsKey(input))
                symbolCountDictionary[input] = symbolCountDictionary[input] + 1;
            else
                symbolCountDictionary.Add(input, 1);
            
            Console.WriteLine("Input numbers: ");
            input = Convert.ToInt32(Console.ReadLine());
        }
       
        foreach (var i in symbolCountDictionary)
        {
          if (i.Value != 1) Console.WriteLine(i.Key);  
        }
    }
}