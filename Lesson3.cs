namespace ConsoleApp1;

public class Lesson3
{
   /*
    * Сделать методы для считывания целых чисел, дробных чисел.
    * Сделать методы для вывода на консоль этих типов данных,
    * массивов целых и дробных чисел (можно доработать любое ДЗ).
    */
   public static void Task1_InOutputMethods()
   {
       int intNum = ReadInt();
       double dblNum = ReadDouble();
       
       PrintInt(intNum);
       PrintDouble(dblNum);
       
       int[] arr1 = new int[5];
       double[] arr2 = new double[5];
       
       MatrixInt(arr1); 
       MatrixDouble(arr2);
       
       PrintMatrixInt(arr1);
       PrintMatrixDouble(arr2);
   }

   public static int ReadInt()
   {
       Console.WriteLine("Input int number: ");
       return Convert.ToInt32(Console.ReadLine());
   }
   public static double ReadDouble()
   {
       Console.WriteLine("Input double number: ");
       return Convert.ToDouble(Console.ReadLine());
   }

   public static void PrintInt(int x)
   {
       Console.WriteLine($"x = {x}");
   }
   
   public static void PrintDouble(double x)
   {
       Console.WriteLine($"x = {x}");
   }
   
   public static void PrintMatrixInt(int[] arr)
   {
       Console.WriteLine("Input int array: ");
       for (int i = 0; i < arr.Length; i++)
       {
           Console.Write(arr[i].ToString() + " ");
       }
       Console.WriteLine(); 
   }
   
   public static void PrintMatrixDouble(double[] arr)
   {
       Console.WriteLine("Input double array: ");
       for (int i = 0; i < arr.Length; i++)
       {
           Console.Write(arr[i] + " ");
       }
       Console.WriteLine(); 
   }
   
   public static void MatrixInt(int[] arr)
   {
       var rnd = new Random();
       for (int i = 0; i < arr.Length; i++)
       {
           arr[i] = rnd.Next(100);
       }
   }
   
   public static void MatrixDouble(double[] arr)
   {
       var rnd = new Random();
       for (int i = 0; i < arr.Length; i++)
       {
           arr[i] = rnd.NextDouble();
       }
   }
   
}