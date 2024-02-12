// Задайте двумерный массив. Найдите суммуу элементов, 
// находящихся на главвной диагонали ( с индексом (0:0);(1;1))

int[,] CreateRndMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int(rowsCount, columnsCount);
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for  (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SumDiag(int [,] matrix)
int sum = 0;
for ( int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = sum + matrix [i, j];
        }
    }
    return sum;
}
int [,] matrix = CreateRndMatrix(4, 4);

int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = sum + matrix [i, j];
        }
    }
}
ShowMatrix(matrix);
System.Console.WriteLine($"Summ = {sum}");