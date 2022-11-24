//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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


int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int m1 = array1.GetLength(0);
    int n1 = array1.GetLength(1);
    int m2 = array2.GetLength(0);
    int n2 = array2.GetLength(1);
    int[,] result = new int[m1, n2];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            int sum = 0;
            for (int k = 0; k < n1; k++) 
            {
                sum = sum + array1[i, k] * array2[k, j];
                result[i, j] = sum;
            }
        }
    }
    return result;
}

Console.Clear();

Console.Write("Введите количество строк первой матрицы: ");
int numberOfrows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int numberOfcolumns1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк второй матрицы: ");
int numberOfrows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int numberOfcolumns2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левой границы диапазона: ");
int leftEdge = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левой границы диапазона: ");
int rightEdge = int.Parse(Console.ReadLine()!);

Console.WriteLine(String.Empty);

int[,] workingArray1 = GetArray(numberOfrows1, numberOfcolumns1, leftEdge, rightEdge);
Console.WriteLine("Первая матрица: ");
Console.WriteLine(String.Empty);
PrintArray(workingArray1);

Console.WriteLine(String.Empty);

int[,] workingArray2 = GetArray(numberOfrows2, numberOfcolumns2, leftEdge, rightEdge);
Console.WriteLine("Вторая матрица: ");
Console.WriteLine(String.Empty);
PrintArray(workingArray2);

int number1 = workingArray1.GetLength(1);
int number2 = workingArray2.GetLength(0);

Console.WriteLine(String.Empty);

if (number1 == number2)
{
    int[,] productOfarrays = MatrixMultiplication(workingArray1, workingArray2);
    Console.WriteLine("Произведение матриц: ");
    Console.WriteLine(String.Empty);
    PrintArray(productOfarrays);
}
else {Console.WriteLine("Невозможно умножить нсогласованные матрицы.");}
