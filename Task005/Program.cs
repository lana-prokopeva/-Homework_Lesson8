// Напишите программу, которая заполнит спирально массив 4 на 4.

// Метод вывода массива на экран

int[,] GetArraySpiral(int[,] array)
{
    int i = 0;
    int j = 0;
    int value = 1;

    while (value <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
            Console.Write($" {array[i,j]} ");

        else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }  
}

int[,] array = new int[4, 4];
int[,] arraySpiral = GetArraySpiral(array);
PrintArray(arraySpiral);