// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Метод создания массива из рандомных значений
int[,] GetArray(int[,] array)
{
    Console.WriteLine("Первоначальный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

// Метод вывода массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);;
        }
        Console.WriteLine();
    }  
}

// Метод нахождения строки с наименьшей суммой элементов

void GetRowMinSumElements(int[,] array)
{
    Console.WriteLine("Масcив сумм:");
    int size = array.GetLength(0);
    int[] sumArray = new int [size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumArray[i] = sum;
        Console.Write($"{sumArray[i]} ");
    }

    int minSum = sumArray[0];
    for (int i = 0; i < sumArray.Length; i++)
    {
        if (sumArray[i] < minSum)
        {
            minSum = sumArray[i];
        }  
    }

    int rowMin = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        if (minSum == sumArray[i] )
        {
            Console.WriteLine();
            Console.Write($"Строка {i+1} имеет наименьшую сумму элементов");
        }  
    }      
    
}

int[,] array = new int[3, 10];
int[,] randomArray = GetArray(array);
PrintArray(randomArray);
GetRowMinSumElements(randomArray);
