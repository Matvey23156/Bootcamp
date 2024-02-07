// Напишите программу, которая считает сумму чисел от 1 до n (1 и 2 тип алгоритма)

using System.Xml.XPath;

Console.Write("Введите число: ");
// функция int.Parse работает быстрее, чем  Convert.ToInt32
int n = int.Parse(Console.ReadLine()!), result = 0; // функция не меняет ячейку, а заменяет данные в ней
//int n = Convert.ToInt32(Console.ReadLine());// функция меняет ячейку и сохраняет данные в новой ячейке
for(int i = 1; i <= n; i++)
 result += i;
System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result} ");
