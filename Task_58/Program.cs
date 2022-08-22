// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц


int[,] FirstMatrix(int m, int n)
{
    int[,] firstmatrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstmatrix.GetLength(1); j++)
        {
            firstmatrix[i, j] = rnd.Next(1, 10);
        }
    }
    return firstmatrix;
}

int[,] SecondMatrix(int n, int k)
{
    int[,] secondmatrix = new int[n, k];
    Random rnd = new Random();
    for (int i = 0; i < secondmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(1); j++)
        {
            secondmatrix[i, j] = rnd.Next(1, 10);
        }
    }
    return secondmatrix;
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

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixAB = new int[matrixA.GetLength(1), matrixB.GetLength(0)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                {
                    matrixAB[i,j] = matrixA[i,j] * matrixB[k, j];
                }
            }
        }
    }
    return matrixAB;
}

int[,] matrixResA = FirstMatrix(3, 3);
PrintMatrix(matrixResA);
Console.WriteLine();
int[,] matrixResB = SecondMatrix(3, 3);
PrintMatrix(matrixResB);
Console.WriteLine();
int[,] matrixResAB = MatrixMultiply(matrixResA, matrixResB);
PrintMatrix(matrixResAB);