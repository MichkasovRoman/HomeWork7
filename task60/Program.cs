// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

bool SearchesEqualElements(int[,,] array3d, int number)
{ //метод ищет элементы трехмерного массива, равные заданному числу number
    int firstDim = array3d.GetLength(0);
    int secondDim = array3d.GetLength(1);
    int thirdDim = array3d.GetLength(2);
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                if (array3d[i, j, k] != number) {return true;}
            }
        }
    }
    return false;
}

int[,,] GetArrayWithoutDuplicate(int firstDim, int secondDim, int thirdDim)
{//метод строит трехмерный массив без повторяющихся двузначных элементов
    int[,,] array3d = new int[firstDim, secondDim, thirdDim];
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                do
                {
                    array3d[i, j, k] = new Random().Next(10, 100);
                }
                while(!SearchesEqualElements(array3d, array3d[i, j, k]));
            }
        }
    }
    return array3d;
}

void GetLineArray(int[,,] array3d)
{ //метод построчно выводит трехмерный массив, добавляя индексы каждого элемента
    int firstDim = array3d.GetLength(0);
    int secondDim = array3d.GetLength(1);
    int thirdDim = array3d.GetLength(2);
    int t = array3d.GetLength(2);
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                Console.WriteLine($"{array3d[i, j, k]}({i}, {j}, {k}) ");
            }
        }
    }
}

Console.Clear();

Console.WriteLine("Введите размеры трехмерного массива.");
Console.Write("Первое измерение: ");
int firstDim = int.Parse(Console.ReadLine()!);
Console.Write("Второе измерение: ");
int secondDim = int.Parse(Console.ReadLine()!);
Console.Write("Третье измерение: ");
int thirdDim = int.Parse(Console.ReadLine()!);

Console.WriteLine(String.Empty);

int[,,] workingArray = GetArrayWithoutDuplicate(firstDim, secondDim, thirdDim);
Console.WriteLine("Элементы трехмерного массива (в скобках указаны индексы): ");
GetLineArray(workingArray);

