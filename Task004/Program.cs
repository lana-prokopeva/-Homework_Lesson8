// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Метод вывода массива на экран
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Страница №{i+1} ");
        

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(2); a++)
            {
                Console.Write($"{array[i, j, a]}{(i,j,a)} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }  
}

int[,,] matrix3D = 
{
    {
        {22, 46},
        {97, 11}
    },
    {
        {67, 36},
        {17, 29}
    }
};
PrintArray(matrix3D);