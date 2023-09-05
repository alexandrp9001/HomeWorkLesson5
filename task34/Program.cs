// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = GenerateArray(10);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(FindEven(arr));

int FindEven (int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0 )
        {
            result++;
        } 
    }
    return result;
}


int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100,1000);
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