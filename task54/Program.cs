// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortArrayRows(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            for (int k = 0; k < n - j; k++)
            {
                if (array[i, k] <= array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
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
Console.WriteLine("Изначальный массив: ");
Console.WriteLine(String.Empty);
PrintArray(workingArray);

Console.WriteLine(String.Empty);

int[,] newArray = SortArrayRows(workingArray);
Console.WriteLine("Массив с отсортированными по убыванию элементами каждой строки: ");
Console.WriteLine(String.Empty);
PrintArray(newArray);


