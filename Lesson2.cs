namespace ConsoleApp1;

public class Lesson2
{
    /// <summary>
    /// Ввести с консоли N чисел.
    /// Вывести сумму, максимальное, минимальное значения,
    /// количество четных чисел, произведение нечетных чисел. 
    /// </summary>
    public static void Task1_CyclesAndConditions()
    {
        Console.WriteLine("Task1: "); 
        Console.WriteLine("Input number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

       for(int i = 0; i < n; i++)
       {
           Console.WriteLine("Input number: ");
           numbers[i] = Convert.ToInt32(Console.ReadLine());
       }
       
       int numbersSum = 0, evenCount = 0, oddComposition = 1;
       int numbersMax = numbers[0], numbersMin = numbers[0];

       for(int i = 0; i < n; i++)
       {
           numbersSum += numbers[i];
    
           if(numbers[i] > numbersMax) numbersMax = numbers[i];
           if(numbers[i] < numbersMin) numbersMin = numbers[i];
           if(numbers[i] % 2 == 0) evenCount++;
           else oddComposition *= numbers[i];
       }
       
       Console.WriteLine("Sum: " + numbersSum + "\n");
       Console.WriteLine("Max: " + numbersMax + "\n");
       Console.WriteLine("Min: " + numbersMin + "\n");
       Console.WriteLine("Even count: " + evenCount + "\n");
       Console.WriteLine("Odd composition: " + oddComposition + "\n");
    }

    /// <summary>
    /// Заполнить с консоли массив из N элементов. Отсортировать.
    /// Вывести результат. N - задается с консоли 
    /// </summary>
    public static void Task2_SortingArray()
    {
        Console.WriteLine("Task2: ");
        Console.WriteLine("Input number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Input number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);
        Console.WriteLine("Array after sorting: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(string.Join(" ,",numbers[i]));
        }
        Console.WriteLine();
    }
    
    /// <summary>
    /// Заполнить 1 матрицы размерности NxN случайными числами.
    /// Вывести на консоль. Сложить 2 матрицы.
    /// Вывести результат. Класс Random для генерации случаных чисел.
    /// </summary>
    public static void Task3_Matrix()
    {
        Console.WriteLine("Task3: ");
        int n = 5;
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int[,] matricesSum1 = new int[n, n];
        var rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix1[i, j] = rand.Next(100);
                matrix2[i, j] = rand.Next(100);
            }
        }
        
        Console.WriteLine("First matrix: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix1[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Second matrix: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix2[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Sum matrix: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matricesSum1[i, j] = matrix1[i, j] + matrix1[i, j];
                Console.Write(matrix2[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}