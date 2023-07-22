// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerationRandomArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetEvenElements(int[] array, bool positive)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (positive)
        {
            if (array[i] % 2 == 0) count++;
        }
    }
    return count;
}

int number = GetInput("Введите количество элементов массива: ");
int[] array = GenerationRandomArray(number);
Console.WriteLine($"Массив [{String.Join(",", array)}]");
Console.WriteLine($"Количество четных чисел {GetEvenElements(array, true)}");