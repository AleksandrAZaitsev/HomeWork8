//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int m, int n)
{
int[,] matrix = new int [m, n];
    for(int i = 0; i < m; i++)
    {
     for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);
        }
    }
return matrix;
}

int[,] RevertMatrix(int[,] matrix)
{
    int[,] NewMatrix = new int [matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            NewMatrix[j,i] = matrix[i,j]; 
        }
    }
    return NewMatrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        System.Console.Write(matrix[i,j] + "\t");;
        }
        System.Console.WriteLine();
        }
System.Console.WriteLine();
}



int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int [,] myMatrix = CreateMatrix(m,n);
PrintMatrix(myMatrix);
PrintMatrix(RevertMatrix(myMatrix));