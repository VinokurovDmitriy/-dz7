// Задайте двумерный массив m x n заполненный случайными вещественными числами

string[] partsMessage = {"строк ", "столбцов ", "знаков после запятой "};
int[] parametersArray = new int[partsMessage.Length];
for(int i = 0; i < parametersArray.Length; i++)
{
    Console.Write("Введите количество " + partsMessage[i]);
    parametersArray[i] = Convert.ToInt32(Console.ReadLine());
}

double[,] array = new double[parametersArray[0], parametersArray[1]];

void FillRandomDoubleArray(double[,] array)
{
    var r = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int factor = r.Next(-20, 21);
            double numDouble = r.NextDouble();
            array[i, j] = Math.Round(factor * numDouble, parametersArray[2]);
        }
    }
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillRandomDoubleArray(array);
PrintArray(array);

