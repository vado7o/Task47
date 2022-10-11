// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

Console.Clear();
Console.WriteLine("Программа, создающая двумерный массив размером m X n, заполненный случайными вещественными числами");

int row = 0;
int column = 0;

while (true)
{
    Console.Write("\nНапишите - из скольки строк должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            row = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество строк массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество строк массива!\n");
}

while (true)
{
    Console.Write("\nНапишите - из скольки столбцов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            column = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество столбцов массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество столбцов массива!\n");
}

double[,] array = FillArray(row, column, -9.9, 9.9);

Console.Write("\nCгенерированный массив: \n");
PrintArray(array);


double[,] FillArray(int row, int column, double min, double max)
{
    double[,] filledArray = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
        filledArray[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
        }
    }
    return filledArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }   
}