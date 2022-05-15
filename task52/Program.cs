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
            Console.Write($"{arr[i, j], 3}");
        }
        Console.WriteLine();
    }
}

double[] GetSumColumnArray(int[,] arr)
{
    double[] sumColumn = new double[arr.GetLength(1)];
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumColumn[j] += arr[i, j];
        }
    }
    return sumColumn;
}

void PrintAverageArrayColumns(double[] columnsSum, int rowCount)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    string separator = "; ";
    for (int i = 0; i < columnsSum.Length; i++)
    {
        if (i == columnsSum.Length - 1)
            separator = ".";
        double sumAverage = Math.Round((float)columnsSum[i] / rowCount, 3);
        Console.Write(sumAverage + separator);
    }
    Console.WriteLine();
}


while (fillParamsArray(paramsArray))
{
    int[,] array = new int[paramsArray[0], paramsArray[1]];
    FillRandomIntArray(array);
    PrintArray(array);
    double[] columnsSum = GetSumColumnArray(array);
    PrintAverageArrayColumns(columnsSum, paramsArray[0]);
};