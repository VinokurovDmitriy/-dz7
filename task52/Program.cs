// Задайте двумерный массив из цлых чисел. Найдите среднее арифметическое каждого столбца

string[] partsMessage = { "строк ", "столбцов " };
int[] paramsArray = new int[partsMessage.Length];
bool fillParamsArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < partsMessage.Length; i++)
    {
        Console.Write($"Введите количество {partsMessage[i]} или число меньше 1 для выхода: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] == 0) return false;
    }
    return true;
}


void FillRandomIntArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 6}");
        }
        Console.WriteLine();
    }
}

void PrintAverageArrayColumns(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое колонок: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sumColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn += array[j, i];
        }
        double averageColumn = Math.Round((double) sumColumn / array.GetLength(0), 2);
        Console.Write($"{averageColumn, 4}; ");
    }
     Console.WriteLine();
}

while (fillParamsArray(paramsArray))
{
    int[,] array = new int[paramsArray[0], paramsArray[1]];
    FillRandomIntArray(array);
    PrintArray(array);
    PrintAverageArrayColumns(array);
};