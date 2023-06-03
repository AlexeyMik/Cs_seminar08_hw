// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
//
void Task58()
{
    int m1 = ReadInt("Введите количество строк 1й матрицы: ");
    int n1 = ReadInt("Введите количество столбцов 1й матрицы: ");
    int[,] matrix1 = new int[m1, n1];

    int m2 = ReadInt("Введите количество строк 2й матрицы: ");
    int n2 = ReadInt("Введите количество столбцов 2й матрицы: ");
    int[,] matrix2 = new int[m2, n2];

    int leftLimit = ReadInt("Введите нижнюю границу генерируемых значений: ");
    int rightLimit = ReadInt("Введите верхнюю границу генерируемых значений: ");

    FillRandomIntMatrix(matrix1, leftLimit, rightLimit);
    FillRandomIntMatrix(matrix2, leftLimit, rightLimit);

    Console.WriteLine("Матриц1: ");
    Print2DimMatrix(matrix1);
    System.Console.WriteLine();

    Console.WriteLine("Матриц2: ");
    Print2DimMatrix(matrix2);
    System.Console.WriteLine();

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Перемножение невозможно: ");
        return;
    }
    int[,] matrixProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    ProductOfMatrix(matrix1, matrix2, matrixProduct);

    System.Console.WriteLine($"Произведение матриц");
    Print2DimMatrix(matrixProduct);
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

void Print2DimMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine($" ");
    }
}

void ProductOfMatrix(int[,] matrixLeft, int[,] matrixRight, int[,] matrixProduct)
{
    if (matrixLeft.GetLength(1) != matrixRight.GetLength(0))
    {
        System.Console.WriteLine($" вычисление произведения не возможно");
        return;
    };
    int iSum = 0;
    for (int i = 0; i < matrixLeft.GetLength(0); i++)
    {
        for (int j = 0; j < matrixRight.GetLength(1); j++)
        {
            iSum = 0;
            for (int k = 0; k < matrixRight.GetLength(0); k++)
            {
                iSum += matrixLeft[i, k] * matrixRight[k, j];
            };
            matrixProduct[i, j] = iSum;
        };
    };
}

Task58();