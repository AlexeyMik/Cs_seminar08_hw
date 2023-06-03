// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
//
void Task56()
{
    //Console.Clear();
    int m = ReadInt("Введите количество строк: ");
    int n = ReadInt("Введите количество столбцов: ");
    int leftLimit = ReadInt("Введите нижнюю границу генерируемых значений: ");
    int rightLimit = ReadInt("Введите верхнюю границу генерируемых значений: ");
    int[,] matrix = new int[m, n];

    FillRandomIntMatrix(matrix, leftLimit, rightLimit);
    Console.WriteLine("Начальная матрица: ");
    Print2DimMatrixWithLineSum(matrix);
    System.Console.WriteLine();
    System.Console.WriteLine($"{FindRowWithMinSum(matrix)} Строка с минимальной суммой");
    //Print2DimMatrixWithLineSum (matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillRandomIntMatrix(int[,] matrix, int iLeftRange, int iRightRange)
{
    Random iRand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = iRand.Next(iLeftRange, iRightRange + 1);
}

void Print2DimMatrixWithLineSum(int[,] matrix)
{
    // Console.WriteLine();
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
            sum += matrix[i, j];
        }
        Console.WriteLine($"  сумма строки={sum}");
    }
}

int FindRowWithMinSum(int[,] matrix)
{
    int iBest = 0;
    int iBestSum = 0;
    int iSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        iBestSum += matrix[0, j];
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        iSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            iSum += matrix[i, j];
        };
        if (iSum < iBestSum)
        {
            iBest = i;
            iBestSum = iSum;
        }
    };
    //System.Console.WriteLine($" лучшая строка {iBest} c суммой {iBestSum}");
    return iBest;
}

Task56();