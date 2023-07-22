//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerationRandomArray(int number, int start, int end)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

int GetEvenElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {

        sum = sum + array[i];

    }
    return sum;
}

int number = GetInput("Введите количество элементов массива: ");
int start = GetInput("Введите начало диапозона: ");
int end = GetInput("Введите конец диапозона: ");
int[] array = GenerationRandomArray(number, start, end);
Console.WriteLine($"Массив [{String.Join(",", array)}]");
Console.WriteLine($"Сумма элементов стоящих на не четных позициях  {GetEvenElements(array)}");