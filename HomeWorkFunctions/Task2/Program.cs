// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int e in array)
    {
        System.Console.Write($"{e} ");
    }
    System.Console.WriteLine();
}

bool GetEven(int elem)
{
    if (elem % 2 == 0)
    {
        return true;
    }
    else return false;
}

int[] newArray = GetRandomArray (5, 0, 999);
int sumEven = 0;
foreach (int e in newArray)
{
   if (GetEven(e) == true)
   {
    sumEven++;
   } 
}
PrintArray(newArray);
System.Console.WriteLine($"в массиве {sumEven} четных элементов");