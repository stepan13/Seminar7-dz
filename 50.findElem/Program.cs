// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


var array = FillArray(4, 5);
PrintArray(array);
int row = AskIntNumber("Введите индекс строки: ");
int column = AskIntNumber("Введите индекс колонки: ");
if (ElementExist(array, row, column))
    System.Console.WriteLine("[" + row + "," + column + "] => " + array[row,column]);
else
    System.Console.WriteLine("Такого элемента не уществует.");

bool ElementExist(int[,] arr, int row, int col)
{
    return ((row < arr.GetLength(0) && (col < arr.GetLength(1))));
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

int AskIntNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    string input = Console.ReadLine() ?? string.Empty;
    return Convert.ToInt32(input);
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