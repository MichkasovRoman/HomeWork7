// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int row, int cols, int minValue, int maxValue)
{
    int[,] array = new int[row, cols];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] SumOfRowElements(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[] vector = new int[m];
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + array[i, j];
        }
    vector[i] = sum;
    }
    return vector;
}

int IndexOfSmallestElement(int[] array)
{
    int minElement = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            array[i] = minElement;
            minElement = array[i];
            index = i;
        }
    }
    return index;
}

Console.Clear();

Console.Write("Введите количество строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левой границы диапазона: ");
int left = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левой границы диапазона: ");
int right = int.Parse(Console.ReadLine()!);

Console.WriteLine(String.Empty);

int[,] workingArray = GetArray(a, b, left, right);
Console.WriteLine("Получившийся массив: ");
Console.WriteLine(String.Empty);
PrintArray(workingArray);

Console.WriteLine(String.Empty);

int[] newArray = SumOfRowElements(workingArray);

int numberOfminsum = IndexOfSmallestElement(newArray);
Console.Write($"Номер строки с наименьшей суммой элементов -- {numberOfminsum}.");
