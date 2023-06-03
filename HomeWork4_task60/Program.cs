// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Task60()
{
    int n1 = ReadInt("Введите 1ю размерность 3х-мерного массива: ");
    int n2 = ReadInt("Введите 2ю размерность 3х-мерного массива: ");
    int n3 = ReadInt("Введите 3ю размерность 3х-мерного массива: ");
    int[,,] array3D = new int[n1, n2, n3];

    FillRandom3DimIntegerArray(array3D, 10, 99);

    Console.WriteLine(" ");
    Print3DimArrayWithIndexes(array3D);
    System.Console.WriteLine();
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillRandom3DimIntegerArray(int[,,] array3Dim, int iLeftRange, int iRightRange)
{
    Random iRand = new Random();
    for (int i = 0; i < array3Dim.GetLength(0); i++)
        for (int j = 0; j < array3Dim.GetLength(1); j++)
            for (int k = 0; k < array3Dim.GetLength(2); k++)
                array3Dim[i, j, k] = iRand.Next(iLeftRange, iRightRange + 1);
}

void Print3DimArrayWithIndexes(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++) // внешний цикл по третьей размерности
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // внутренний цикл по столбцам =вдоль строки
            {
                Console.Write($"{matrix[i, j,k]}({i},{j},{k}) \t");
            }
            Console.WriteLine($" ");
        };
        Console.WriteLine($"----"); //между "этажами" выводим разрыв с пунктирами
    }
}

Task60();