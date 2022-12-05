// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = FillArray(3,6);
PrintArray(array);
PrintColumnAverage(array);

void PrintColumnAverage(int[,] arr)
{
    string result = "";
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += arr[j, i];
        }
        double average = Math.Round(sum / rows, 2);
        result += average + ((i == columns - 1) ? string.Empty : "; ");
    }
    System.Console.WriteLine(result);
}

int[,] FillArray(int rows, int columns)
{
    Random rand = new Random();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rand.Next(0, 11);
        }
    }
    return result;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}