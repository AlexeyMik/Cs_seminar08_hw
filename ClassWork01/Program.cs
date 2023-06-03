// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
void input_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);  //[-10;10]
}

void print_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

bool TransponMatrix(ref int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        return false;
    }
    int buffer = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            buffer = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = buffer;
        }
    return true;
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
input_matrix(matrix);
print_matrix(matrix);
if (TransponMatrix(ref matrix))
{
    System.Console.WriteLine();
    print_matrix(matrix);
}
else System.Console.WriteLine($" матрица не квадратная");
