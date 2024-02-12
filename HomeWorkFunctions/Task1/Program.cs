// Задача 1: Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.


int sumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
bool GetEven(int sum)
{
    if (sum % 2 == 0)
    {
        return true;
    }
    else return false;
}

while (true)
{
    System.Console.WriteLine($"введите число или q для выхода:");

    string input = Console.ReadLine()!;
    if (input == "q")
    {
        break;
    }
    int numb;
    if (int.TryParse(input, out numb))

    {
        int number = int.Parse(input);
        int sum = sumNumbers(number);
        if (GetEven(sum) == true)
        {
            System.Console.WriteLine($"четное - EXIT");
            break;
        }
        System.Console.WriteLine($"нечетное, введите еще");

    }
    else
    {
        Console.WriteLine("Ошибка, введите целое число или 'q'.");
    }

}



// while (true) // Бесконечный цикл
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine() !; // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
// {
// int sum = 0;
// while (number > 0) // Вычисление суммы цифр числа {
// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из числа }
// if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
// {
// Console.WriteLine("[STOP]");
// break; }
// }
// else // Если ввод не является числом и не 'q', повторить запрос
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
// } }


// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine() !; // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
