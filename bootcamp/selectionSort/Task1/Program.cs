// Сортировка выбором O(n^2)

/*
// Показательный пример сортиировки выбором
// Отталкиваемся от минимального элемента
[45, 23, -10, 5, 3, 9, 1]
min = -10
[-10, 23, 45, 5, 3, 9, 1]
min = 1
[ -10, 1, 45, 3, 9, 23]
min = 3
[-10, 1, 3, 5, 45, 9, 23]
min = 5
[-10, 1, 3, 5, 45, 9, 23]
min = 9
[-10, 1, 3, 5, 9, 45, 23]
min = 23
[-10, 1, 3, 5. 9, 23, 45]
*/

// Реализация данного метода через функцию ( она будет возвращать отсортированный массив )

int[] sortVibor(int[] array)
{
    // Cчетчики цикла лучше всего обзывать i, j, k, m, n
    for (int i = 0; i < array.Length; i++)
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
            indexMin = j;
        }
        if (array[indexMin] == array[i])
        continue; // переход к следующей интерации цикла

        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
        
    }

    return array;
}


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-20,21); // [-20; 20]
}

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
System.Console.WriteLine($"Начаальный массив: [{String.Join (", ", array)}]");
System.Console.WriteLine($"Конечный массив: [{String.Join (", ", sortVibor(array))}]");