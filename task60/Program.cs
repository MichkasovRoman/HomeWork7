// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int row, int cols, int zet)
{
    int[,,] array = new int[row, cols, zet];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < zet; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void GetLineArray(int[,,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int t = array.GetLength(2);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < t; k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
        }
    }
}

Console.Clear();
int[,,] workingArray = GetArray(2, 2, 2);
GetLineArray(workingArray);

