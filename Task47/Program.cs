// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double[,] FillMatrixRndDouble()
{
Random rnd = new Random();
int rows = rnd.Next(3,6); // поскольку в условии нет уточнения, кто задает размер массива, 
int columns = rnd.Next(3,6); // сделала случайную генерацию размера для разнообразия
double[,] matrix = new double[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Math.Round(rnd.NextDouble()*30, 2);
    }
}
return matrix;
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
        else Console.Write($"{matrix[i,j], 5}");
    }
    Console.WriteLine(" |");
}
}

double[,] massive2D = FillMatrixRndDouble();
PrintMatrix(massive2D);