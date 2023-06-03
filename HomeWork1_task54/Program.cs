// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
//
void Task54()
{
    Console.Clear();
    Console.Write("Введите размер матрицы (число строк и столбцов через пробел): ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];

    FillRandomIntMatrix(matrix, -10, 10);
    Console.WriteLine("Начальная матрица: ");
    Print2DimMatrix(matrix);
    ChangeOrderInEachLineToDecreasing(matrix);
    System.Console.WriteLine();
    System.Console.WriteLine("Матрица с элементами по убывающей в каждой строке");
    Print2DimMatrix(matrix);
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
    // Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ChangeOrderInEachLineToDecreasing(int[,] matrix)
{
    int buffer = 0;
    int jOfMax = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            jOfMax = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
                if (matrix[i, k] > matrix[i, jOfMax])
                {
                    jOfMax = k;
                };
            buffer = matrix[i, j];
            matrix[i, j] = matrix[i, jOfMax];
            matrix[i, jOfMax] = buffer;
        }
    };
}

Task54();