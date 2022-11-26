// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
 
int[,] GetSquareArray(int number, int minValue, int maxValue)
{
    int[,] array2d = new int[number, number];
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number; j++)
        {
            array2d[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array2d;
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

int[] LineUpArray2d(int[,] array2d)
{
    int[] array = new int[array2d.GetLength(0) * array2d.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array[index] = array2d[i, j];
            index++;
        }
    }
    return array;
}

int[] OrderArray(int[] array)
{
    int temp = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[i] > array[k])
            {
                temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }
        }
    }
    return array;
}

int[,] GetSpiral(int[,] array2d)
{
    int firstDim = array2d.GetLength(0);
    int secondDim = array2d.GetLength(1);
    int[] array = LineUpArray2d(array2d);
    int[] order = OrderArray(array);
    int[,] spiral = new int[firstDim, secondDim];
    int index1 = 0, index2 = 0;
    int temp1 = firstDim; int temp2 = 0;
    int d = 0; int x = 0; int y = 1;
    for (int i = 0; i < firstDim * secondDim; i++)
    {
        spiral[index1, index2] = order[i];
        temp1 = temp1 - 1;
        if (temp1 == 0)
        {
            temp1 = firstDim * (d % 2) + secondDim * ((d + 1) % 2) - (d / 2 - 1) - 2;
            temp2 = y;
            y = x - (x + x);
            x = temp2;
            d = d + 1;
        }
        index1 = index1 + x;
        index2 = index2 + y; 
    }
    return spiral;
}

Console.Clear();
Console.Write("Введите размер квадратного массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левой границы диапазона: ");
int leftEdge = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левой границы диапазона: ");
int rightEdge = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Empty);
int[,] workingArray = GetSquareArray(size, leftEdge, rightEdge);
Console.WriteLine("Изначальный массив: ");
PrintArray(workingArray);
Console.WriteLine(String.Empty);
int[,] spiralArray = GetSpiral(workingArray);
Console.WriteLine("Массив, полученный из первого массива расстановкой элементов по спирали (по часовой стрелке): ");
PrintArray(spiralArray);
