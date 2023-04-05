namespace ConsoleApp1;

public class Lesson2
{
    /*
        Ввести с консоли N чисел.
        Вывести сумму, максимальное, минимальное значения, 
        количество четных чисел, произведение нечетных чисел.
    */
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
       
       int s = 0, evenCount = 0, oddComposition = 1;
       int max = numbers[0], min = numbers[0];

       for(int i = 0; i < n; i++)
       {
           s = s + numbers[i];
    
           if(numbers[i] > max) max = numbers[i];
           if(numbers[i] < min) min = numbers[i];
           if(numbers[i] % 2 == 0) evenCount = evenCount + 1;
           else oddComposition = oddComposition * numbers[i];
       }
       
       Console.WriteLine("Sum: " + s + "\n");
       Console.WriteLine("Max: " + max + "\n");
       Console.WriteLine("Min: " + min + "\n");
       Console.WriteLine("Even count: " + evenCount + "\n");
       Console.WriteLine("Odd composition: " + oddComposition + "\n");
    }

    /*
     * Заполнить с консоли массив из N элементов. Отсортировать.
     * Вывести результат. N - задается с консоли
     */
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
            Console.Write(numbers[i]);
        }
        Console.WriteLine();
    }
    
    /*
     * Заполнить 2 матрицы размерности NxN случайными числами.
     * Вывести на консоль. Сложить 2 матрицы.
     * Вывести результат. Класс Random для генерации случаных чисел.
     */
    public static void Task3_Matrix()
    {
        Console.WriteLine("Task3: ");
        int n = 5;
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int[,] sumMatrix1 = new int[n, n];
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
                sumMatrix1[i, j] = matrix1[i, j] + matrix1[i, j];
                Console.Write(matrix2[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}