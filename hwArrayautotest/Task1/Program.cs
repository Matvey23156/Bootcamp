// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5


//   int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
//         int minRange = 10;
//         int maxRange = 90;
//         int count = 0;
//         foreach (int e in numbers)
//         {
//             if (e >= minRange && e <= maxRange)
//             {
//                 count++;
//             }
            
//         }
        
//         System.Console.WriteLine(count);


// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
// int count = 0;

// foreach (int e in array)
// {
//     if (e % 2 == 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);


//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double FindMin(double[] numbers)
{
    double Min = numbers[0];
    foreach (double e in numbers)
    {
        if (e < Min)
        {
            Min = e;
        }
        
    }
return Min;
}
double Min = FindMin(numbers);
System.Console.WriteLine(Min);

double FindMax(double[] numbers)
{

    double Max = numbers[0];
    foreach (double e in numbers)
    {
        if (e > Max)
        {
            Max = e;
        }
    }
    return Max;
}
double Max = FindMax(numbers);
System.Console.WriteLine(Max);
System.Console.WriteLine(Max - Min);