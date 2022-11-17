// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
void SearchElementInMatrix(int[,] matrix, int rows, int columns)
{
    if(rows < matrix.GetLength(0) && columns < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с индексом [{rows},{columns}] равен {matrix[rows,columns]}");
    }
    else
    {
        Console.WriteLine("Элемента с таким индексом в массиве нет");
    }
}

Console.WriteLine("Укажите количество строк в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в двумерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] massive2D = FillMatrixRndInt(row, column, 1, 20);
PrintMatrix(massive2D); //делаю вывод только для проверки, правильно ли срабатывает программа, по условию вывод здесь не нужен 

Console.WriteLine("Укажите порядковый номер строки: ");
int rowForSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите порядковый номер столбца: ");
int columnForSearch = Convert.ToInt32(Console.ReadLine());

SearchElementInMatrix(massive2D, rowForSearch, columnForSearch);