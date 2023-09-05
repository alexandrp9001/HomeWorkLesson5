// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = GenerateArray(10);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(SumOddPosition(arr));

int SumOddPosition(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i += 2 )
    {
        result += arr[i];
        System.Console.WriteLine(i);

    }
    return result;
}


int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0,10);
    }
    return result;
}


void PrintArray (int[] array)
{
    foreach(int i in array) 
    {
        Console.Write($"{i} ");
    }
}