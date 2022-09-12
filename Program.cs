// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Write("Введите количество строк: ");
// int NumberRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int NumberColumn = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[NumberRow, NumberColumn];

// FillArrayRandomNumbers(array);
// Console.WriteLine();
// Console.WriteLine("Полученный массив:");
// PrintArray(array);
// OrderElementLine(array);
// Console.WriteLine();
// Console.WriteLine("Отсортированный массив:");
// PrintArray(array);

// void OrderElementLine(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите размер массива: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());
int NumberRow = SizeArray;
int NumberColumn = SizeArray;

int[,] array = new int[NumberRow, NumberColumn];

FillArrayRandomNumbers(array);
Console.WriteLine();
Console.WriteLine("Полученный массив:");
PrintArray(array);

int MinSumLine = 0;
int SumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int TempSumLine = SumLineElements(array, i);
    if (SumLine > TempSumLine)
    {
        SumLine = TempSumLine;
        MinSumLine = i;
    }
}

Console.WriteLine();
Console.WriteLine($"Строка с номером {MinSumLine+1} является строкой с наименьшей суммой элементов равной {SumLine}");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}