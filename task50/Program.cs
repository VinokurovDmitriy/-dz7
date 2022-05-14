// Программа принимает на вход позиции элемента двухмерного  массива и возвращает
//значение этого элемента или сообщает что такого элемента нет в массиве
string[] partsMessage = { "количество строк ", "количество столбцов ", "номер строки ", "номер столбца " };
int[] paramsArray = new int[partsMessage.Length];
for (int i = 0; i < partsMessage.Length; i++)
{
    Console.Write("Введите " + partsMessage[i]);
    paramsArray[i] = Convert.ToInt32(Console.ReadLine());
}
int[,] array = new int[paramsArray[0], paramsArray[1]];

void FillRandomIntArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 101);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetElement(int[,] arr, int row, int column)
{
    Console.WriteLine();
    if (arr.GetLength(0) >= row && arr.GetLength(0) >= column)
        Console.WriteLine(arr[row, column]);
    else
        Console.WriteLine("В массиве нет такого элемента");
}

FillRandomIntArray(array);
PrintArray(array);
GetElement(
    arr: array,
    row: paramsArray[2] - 1,
    column: paramsArray[3] - 1
    );
