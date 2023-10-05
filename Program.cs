// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void printarray(string[] arr) // вывод массива в терминал
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");

    }
    Console.Write("]");
}

string[] StringInput() // ввод массива с клавиатуры
{
    Console.WriteLine("введите количество элементов массива");
    int N = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[N];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"введите {i + 1}-ый элемент");
        arr[i] = Convert.ToString(Console.ReadLine());
        while (arr[i].Length == 0)
        {
            Console.WriteLine($"введите не нулевое значение");
            arr[i] = Convert.ToString(Console.ReadLine());
        }
    }
    Console.WriteLine("изначальный массив:");
    printarray(arr);
    return arr;
}

string[] ArrayModifier(string[] arr)  // Создает новый массив удовлетворяющий условиям задачи
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++) // счет количества элементов массива подходящих под условие задачи
    {
        if (arr[i].Length < 4)
        {
            Count++;
        }
    }
    string[] NewArr = new string[Count];
    int k = 0;
    for (int j = 0; j < arr.Length; j++) // заполнение нового массива
    {
        if (arr[j].Length < 4)
        {
            NewArr[k] = arr[j];
            k++;
        }
    }
    Console.WriteLine("конечный массив:");
    printarray(NewArr);
    return NewArr;
}

string[] array = StringInput();
Console.WriteLine();
ArrayModifier(array);
