// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//
void Task62()
{
    int n1 = ReadInt("Введите 1ю размерность матрицы: ");
    int n2 = ReadInt("Введите 2ю размерность матрицы: ");
    int[,] matrix = new int[n1, n2];

    FillU(matrix);

    Console.WriteLine("Заполненная матрица ");
    Print2DimArray(matrix);
    System.Console.WriteLine();
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillU(int[,] matr)
{
    int Limit = matr.GetLength(0) * matr.GetLength(1);
    int count = 0;
    int jLeft = 0;
    int jRight = matr.GetLength(1) - 1;
    int iUp = 0;
    int iDown = matr.GetLength(0) - 1;
    int stageCount = 0;

    int showFlag = ReadInt("Введите 1, если хотите выводить промежуточные результаты: ");
    // int showFlag = 1;

    while (count < Limit)
    {
        for (int j = jLeft; j <= jRight; j++)// идем по верхней горизонтали вправо
        {
            count++;
            matr[iUp, j] = count;
        };
        iUp += 1;
        if (showFlag == 1) ShowMe(matr, iUp, iDown, jLeft, jRight, ref stageCount, count);

        for (int i = iUp; i <= iDown; i++)  // идем по правой вертикали вниз
        {
            count++;
            matr[i, jRight] = count;
        };
        jRight -= 1;
        if (showFlag == 1) ShowMe(matr, iUp, iDown, jLeft, jRight, ref stageCount, count);

        for (int j = jRight; j >= jLeft; j -= 1) // идем по нижней горизонтали влево
        {
            count++;
            matr[iDown, j] = count;
        };
        iDown -= 1;
        if (showFlag == 1) ShowMe(matr, iUp, iDown, jLeft, jRight, ref stageCount, count);

        for (int i = iDown; i >= iUp; i -= 1) // идем по левой вертикали вверх
        {
            count++;
            matr[i, jLeft] = count;
        };
        jLeft += 1;
        if (showFlag == 1) ShowMe(matr, iUp, iDown, jLeft, jRight, ref stageCount, count);
    }
}
void ShowMe(int[,] matr, int iUp, int iDown, int jLeft, int jRight, ref int stageCount, int count)
// для трассировки 
{
    Print2DimArray(matr);
    Console.WriteLine($"iUp={iUp}  iDown={iDown}  jLeft={jLeft}  jRight={jRight}  этап {stageCount}  count={count}");
    stageCount++;
    System.Console.WriteLine("Для продолжения нажмите любую клавишу: ");
    Console.ReadKey();
}
void Print2DimArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // внутренний цикл по столбцам =вдоль строки
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine($" ");
    }
}

Task62();