// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый
// элемент станет последним, второй – предпоследним и т.д.)

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

int size = 5;
int[] newArray = GetRandomArray(size, 0, 999);
PrintArray(newArray);
int[] ReversArray = new int[size];
for (int i = 0; i < size; i++)
{
    ReversArray[size-1-i] = newArray[i];
}
PrintArray(ReversArray);  