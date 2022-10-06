// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// Метод создания массива из рандомных значений
int[,] GetArray(int[,] array)
{
    Console.WriteLine("Первоначальный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

// Метод упорядочивания строк по убыванию
int[,] GetRowInDescendingOrder(int[,] array)
{
    Console.WriteLine("Новый массив:");
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            for (int a = 0; a < array.GetLength(1)-1; a++)
            {
                if (array[i, a] < array[i, a+1]) 
                {
                tmp = array[i, a+1];
                array[i, a+1] = array[i, a];
                array[i, a] = tmp;             
                }
            }        
            
        }
    }
    return array;
}

int[,] array = new int[2, 5];
int[,] randomArray = GetArray(array);
PrintArray(randomArray);
int[,] newArray = GetRowInDescendingOrder(randomArray);
PrintArray(newArray);