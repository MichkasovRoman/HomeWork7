// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] GetArrayWithoutDuplicate(int size)
{ // метод генерирует одномерный массив с неповторяющимися двузначными элементами
    int[] array = new int[size];
    bool SearchesEqualElements(int number, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (array[i] == number) {return true;}
        }
        return false;
    }
    for (int i = 0; i < size; i++)
    {
        do
        {
            array[i] = new Random().Next(10, 100);
        }
        while(SearchesEqualElements(array[i], i));
    }
    return array;
}

int[,,] GetArray3d(int firstDim, int secondDim, int thirdDim)
{ //метод генерирует трехмерный массив с неповторяющимися двухначными элементами
    int[] array = GetArrayWithoutDuplicate(firstDim * secondDim * thirdDim);
    int[,,] array3d = new int[firstDim, secondDim, thirdDim];
    int index = 0;
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                array3d[i, j, k] = array[index++];
            }
        }
    }
    return array3d;
}

void GetLineArray3d(int[,,] array3d)
{ //метод построчно выводит трехмерный массив, добавляя индексы каждого элемента
    int firstDim = array3d.GetLength(0);
    int secondDim = array3d.GetLength(1);
    int thirdDim = array3d.GetLength(2);
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                Console.Write($"{array3d[i, j, k]}({i}, {j}, {k}) ");
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

int[,,] workingArray = GetArray3d(firstDim, secondDim, thirdDim);
Console.WriteLine("Элементы трехмерного массива (в скобках указаны индексы): ");
GetLineArray3d(workingArray);

