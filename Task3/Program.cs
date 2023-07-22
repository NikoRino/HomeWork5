// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerationRandomArray(int number, int start, int end)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(start * 100, end * 100);
        array[i] = array[i] / 100;
    }
    return array;
}

double GetSumMinMax(double[] array)
{
    double max = array[1];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else
            if (array[i] < min)
            min = array[i];
    }
    double sum = (max - min);
    return sum;
}

int number = GetInput("Введите количество элементов массива: ");
int start = GetInput("Введите начало диапозона: ");
int end = GetInput("Введите конец диапозона: ");
double[] array = GenerationRandomArray(number, start, end);
Console.WriteLine($"Массив [{String.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом {(String.Format("{0:N2}", GetSumMinMax(array)))}");