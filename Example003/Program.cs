//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] CreatingMatrix(int numberRows, int numberColumns)
{
    int[,] matrix = new int[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] CountElems(int[,] array)
{
    int[] countDictionary = new int[9];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            countDictionary[array[i, j] - 1]++;
        }
    }
    return countDictionary;
}

void WriteCountDictionary(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            Console.WriteLine(i + 1 + " встречается " + array[i] + " раз");
        }
    }
}

int[,] matrix = CreatingMatrix(4, 4);
PrintMatrix(matrix);
WriteCountDictionary(CountElems(matrix));

