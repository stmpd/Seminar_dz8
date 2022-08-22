// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int m, int n)  
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 5);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int[] StringSum(int[,] matrix)
{
    int[] newMatrix = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            {
                sum = sum + matrix[i, j];
                newMatrix[i] = sum;
            }
        }
        sum = 0;
    }
    return newMatrix;
}

void minString(int[] array)
{
    int index = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (index > array[i])
        {
            index = array[i];
            int min = index;
            count = i + 1;
        }
    }
    if (count == 0)
    {
        count++;
    }
    Console.WriteLine($"Строка с наименьшей суммой: {count} строка");
}

int[,] matrixRes = GetMatrix(5, 4);
PrintMatrix(matrixRes);
Console.WriteLine();
int[] sumResult = StringSum(matrixRes);
minString(sumResult);