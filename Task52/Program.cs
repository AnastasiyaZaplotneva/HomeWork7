// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] FillMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // 2
{
    for (int j = 0; j < matrix.GetLength(1); j++) //
    {
        matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
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

void PrintArray(double[] array)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write($"{array[i], 6} ");
    }
}

double[] AverageInColumns(int[,] matrix)
{
    double[] arrayWithAvarage = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++) // 2
    {
        for (int i = 0; i < matrix.GetLength(0); i++) //
        {
            arrayWithAvarage[j] += matrix[i,j]; // 2 - 3
        }
        arrayWithAvarage[j] = arrayWithAvarage[j]/matrix.GetLength(0);

    }
    return arrayWithAvarage;
}

Console.WriteLine("Укажите количество строк в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в двумерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] massive2D = FillMatrixRndInt(row, column, -10, 100);
PrintMatrix(massive2D);

double[] arrayWithResult = AverageInColumns(massive2D);
Console.WriteLine("Среднее арифметическое каждого столбца");
PrintArray(arrayWithResult);