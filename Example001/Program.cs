//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int number = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = number;
    }
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int [,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);
ChangeMatrix(matrix);
PrintMatrix(matrix);