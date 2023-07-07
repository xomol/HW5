// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


/*Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");

int evenNumbers = 0;

foreach (int el in array)
{
    if (el % 2 == 0)
    {
        evenNumbers += 1;
    }
    else evenNumbers += 0;
}

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

Console.WriteLine($"Количество четных числе: {evenNumbers}");*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


/*Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");

int sum = 0;
int i = 0;

while (i < size)
{
    sum = sum + array[i];
    i = i + 2;
}

Console.WriteLine($"Сумма элементов, стоиящих на нечетных позициях: {sum}");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 21);
    }
    return result;
}*/


// Задача 38: Задайте массив целых двухзначных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**


/*Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");

int min = array[0];
int max = array[0];

foreach (int i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}

Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10, 100);
    }
    return result;
}*/