// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = AskIntNumber("Введите количество строк: ");
int columns = AskIntNumber("Введите количество колонок: ");
var array = FillArray(rows,columns);
PrintArray(array);

double[,] FillArray(int rows, int columns)
{
    Random rand = new Random();
    double[,] result = new double[rows,columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = -10 + 20 * rand.NextDouble(); //случайные числа от -10 до 10
        }
    }
    return result;
}

int AskIntNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    string input = Console.ReadLine() ?? string.Empty;
    return Convert.ToInt32(input);
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double number = Math.Round(arr[i,j],2);
            System.Console.Write(number + " ");
        }
        System.Console.WriteLine();
    }
}