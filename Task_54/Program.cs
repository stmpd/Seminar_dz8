// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

void Sorting(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                int max = matrix[i, z];
                if (matrix[i, z] < matrix[i, z + 1])
                {
                    int temp = matrix[i, z + 1];
                    matrix[i, z + 1] = matrix[i, z];
                    matrix[i, z] = temp;
                    max = matrix[i, z];
                }
            }
        }
    }
}

int[,] matrixRes = GetMatrix(3, 4);
PrintMatrix(matrixRes);
Console.WriteLine();
Sorting(matrixRes);
PrintMatrix(matrixRes);