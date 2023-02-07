/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] GetMatrix(int rows, int columns)
{
    double [,] Matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = rnd.NextDouble()*rnd.Next(-10,10);
        }

    }
    return Matrix;

}

void PrintMatrix(double[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            System.Console.Write($" {Matrix[i, j]:f2} ");
        }
           Console.WriteLine();
    }
}

int m = 3;
int n = 4;
double [,] matrix = GetMatrix(m,n);
PrintMatrix (matrix);