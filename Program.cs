// Задача №47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
void Task47()
{
    Console.Write("Введите число строк m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (10 - (-9)) + (-9);
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//Задача №50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void Task50()
{
    Console.Write("Введите число строк m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Задан массив:");
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.Write("Введите первый индекс: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второй индекс: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if ((x < array.GetLength(1) & x >= 0) & (y < array.GetLength(0) & y >= 0))
    {
        Console.WriteLine($"Значение элемента: {array[y, x]}");
    }
    else
    {
        Console.WriteLine($"Такого элемента нет");
    }
}

//Задача №52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Task52()
{
    Console.Write("Введите число строк m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Задан массив:");
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double ar = sum / m;
        ar = Math.Round(ar, 1);
        Console.Write(ar + "; ");
    }
}

// Для выбора программы:
Console.WriteLine("Выберите программу:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 47)
{
    Task47();
}
else if (number == 50)
{
    Task50();
}
else if (number == 52)
{
    Task52();
}
else
{
    Console.WriteLine("Ошибка (такой программы не существует)");
}
