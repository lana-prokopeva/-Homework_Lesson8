// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

// Метод создания массива из рандомных значений
int[,] GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(2, 10);
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
            Console.Write($"{array[i, j]} ");;
        }
        Console.WriteLine();
    }  
}

// Метод нахождения произведения двух матриц
int[,] GetProductTwoMatrices(int[,] array1, int[,] array2)
{
    int[,] productArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int a = 0; a < array2.GetLength(0); a++)
            {  
                productArray[i, j] += (array1[i, a] * array2[a, j]);            
            }                      
        }
    }
    return productArray;
}

Console.WriteLine("Первый массив:");
int[,] array1 = new int[2, 2];
int[,] randomArray1 = GetArray(array1);
PrintArray(randomArray1);
Console.WriteLine("Второй массив:");
int[,] array2 = new int[2, 2];
int[,] randomArray2 = GetArray(array2);
PrintArray(randomArray2);
Console.WriteLine("Массив произведения двух матриц:");
int[,] productTwoMatrices = GetProductTwoMatrices(randomArray1, randomArray2);
PrintArray(productTwoMatrices);