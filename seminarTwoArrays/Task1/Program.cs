using System.ComponentModel.DataAnnotations.Schema;

int[,] GetArray(int rows,int cols, int minValue = 0, int maxValue = 10)
{
int[,] table = new int[rows, cols];

var rnd = new Random();

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(i); j++)
    {
        table[i, j] = rnd.Next(minValue, maxValue);

    }
}
return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int Sum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

    }
   return sum;
}




int[,] array = GetArray(2, 3);

PrintArray(array);

System.Console.WriteLine(Sum(array));



// System.Console.WriteLine(array.Length);
// System.Console.WriteLine(table.Length);
// System.Console.WriteLine(table.GetLength(0));
// System.Console.WriteLine(table.GetLength(1));