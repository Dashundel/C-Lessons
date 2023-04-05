namespace ConsoleApp1;

public class HW2
{
    /*
      * Заполнить массив длиной N случайными числами.
      * Ввести с консоли число A.
      * Вывести Yes, если число A есть в массиве, No - в противном случае.
      */
   public static void Task1_ExistAInArray()
   {
       Console.WriteLine("Task1: ");
       int n = 5;
       int[] array = new int[n];
       var random = new Random();
       
       Console.WriteLine("Input number A: ");
       int a = Convert.ToInt32(Console.ReadLine());

       for (int i = 0; i < n; i++)
       {
           array[i] = random.Next(100);
           Console.Write(array[i].ToString() + " ");
       }
       Console.WriteLine(); 

       for (int i = 0; i < n; i++)
       {
           if (array[i] == a)
           {
               Console.WriteLine("YES");
               break;
           }
           else 
           {
               if (i == n - 1) Console.WriteLine("No"); 
           }
       }
   }
    
   /*
    * Заполнить матрицу NxM случайными числами.
    * Из каждой строки выбрать минимальный элемент, занести его в массив.
    * Отсортировать полученный массив и вывести его значения в обратном порядке.
    */
   public static void Task2_MinArray()
   {
       Console.WriteLine("Task2: ");
       int n = 5, m = 6;
       int[,] matrix = new int[n, m];
       int[] minArray = new int[n];
       var random = new Random();
       
       Console.WriteLine("Matrix: ");

       for (int i = 0; i < n; i++)
       {
           for (int j = 0; j < m; j++)
           {
               matrix[i,j] = random.Next(100);
               Console.Write(matrix[i,j].ToString() + " "); 
           }
           Console.WriteLine();
       }
       
       for (int i = 0; i < n; i++)
       {
           minArray[i] = matrix[i,0];
           for (int j = 0; j < m; j++)
           {
               if (matrix[i, j] < minArray[i]) minArray[i] = matrix[i, j];
           }
       }
       Array.Sort(minArray);
       
       Console.WriteLine("Array with min elements of strings: ");
       
       for (int i = n - 1; i >= 0; i--)
       {
           Console.Write(minArray[i].ToString() + " ");
       }
       Console.WriteLine(); 
   }
    
   /*
    * Калькулятор. С консоли вводится левый операнд, операция, правый операнд.
    * Выводится результат операции над операндами.
    * Реализовать как минимум 4 операции, обработку ошибок (деление на 0 и др).
    */
   public static void Task3_Calculator()
   {
       Console.WriteLine("Task3: ");
       
       Console.WriteLine("Input first operand: ");
       int a = Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine("Input operation (+, -, /, *): ");
       string operation = Console.ReadLine();
       
       Console.WriteLine("Input second operand: ");
       int b = Convert.ToInt32(Console.ReadLine());
       
       if(operation == "+") Console.WriteLine(a + b);
       if(operation == "-") Console.WriteLine(a - b);
       if(operation == "*") Console.WriteLine(a * b);
       if(operation == "/")
       {
           if(b == 0) Console.WriteLine("You can't divide by zero!");
           else Console.WriteLine(a / b);
       }
   }
}