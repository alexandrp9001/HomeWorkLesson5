// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

 double[] arr = GenerateArray(10);
 PrintArray(arr);
//  System.Console.WriteLine();
//  System.Console.WriteLine(MaxValueArray(arr));
//  System.Console.WriteLine();
//  System.Console.WriteLine(MinValueArray(arr));


//  int MaxValueArray(int[] array)
//  {
//      int max = arr[0];
//      for(int i = 0; i < array.Length; i++ )
//      {

//          if(max < arr[i])  max = arr[i];
//      }
//      return max;
//  }


//  int MinValueArray(int[] array)
//  {
//      int min = arr[0];
//      for(int i = 0; i < array.Length; i++ )
//      {

//          if(min > arr[i])  min = arr[i];
//      }
//      return min;
//  }


double[] GenerateArray(double length)
{
    double[] result = new double[length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-10.0,10.0);
    }
    return result;
}


 void PrintArray (double[] array)
 {
     foreach(double i in array) 
     {
         Console.Write($"{i} ");
     }
 }