// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк: ");
int NumberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int NumberColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[NumberRow, NumberColumn];

FillArrayRandomNumbers(array);
Console.WriteLine();
Console.WriteLine("Полученный массив:");
PrintArray(array);
OrderElementLine(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(array);

void OrderElementLine(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк прямоугольного массива: ");
int NumberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов прямоугольного массива: ");
int NumberColumn = Convert.ToInt32(Console.ReadLine());

while(NumberRow == NumberColumn)
{
    Console.Write("Количество строк и столбцов совпадает. Повторно введите количество строк: ");
    NumberRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество строк и столбцов совпадает. Повторно введите количество столбцов: ");
    NumberColumn = Convert.ToInt32(Console.ReadLine());
}

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
Console.WriteLine($"Строка с номером {MinSumLine + 1} является строкой с наименьшей суммой элементов равной {SumLine}");

int SumLineElements(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
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

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк 1-ой матрицы: ");
int FirstMatrixRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-ой матрицы равное количеству строк 2-ой матрицы: "); // условие перемножения матриц
int MatrixColumnAndRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-ой матрицы: ");
int TwoMatrixColumn = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int[FirstMatrixRow, MatrixColumnAndRow];
int[,] TwoMatrix = new int[MatrixColumnAndRow, TwoMatrixColumn];

FillArrayRandomNumbers(FirstMatrix);
Console.WriteLine();
Console.WriteLine("Полученная первая матрица:");
PrintArray(FirstMatrix);

FillArrayRandomNumbers(TwoMatrix);
Console.WriteLine();
Console.WriteLine("Полученная вторая матрица:");
PrintArray(TwoMatrix);

int[,] ResultMulti = new int[FirstMatrixRow, TwoMatrixColumn];

Console.WriteLine();
Multiplication(FirstMatrix, TwoMatrix, ResultMulti);
Console.WriteLine("Результат перемножения двух матриц:");
PrintArray(ResultMulti);

void Multiplication(int[,] MatrixOne, int[,] MatrixSecond, int[,] Result)
{
    for (int i = 0; i < Result.GetLength(0); i++)
    {
        for (int j = 0; j < Result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < MatrixOne.GetLength(1); k++)
            {
                sum = sum + (MatrixOne[i, k] * MatrixSecond[k, j]);
            }
            Result[i, j] = sum;
        }
    }
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

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// В этой задаче подглядел как заполнить массив рандомными числами.

Console.WriteLine("Введите размер трехмерного массива.");
Console.WriteLine();
Console.Write("Введите X: ");
int SizeX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int SizeY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int SizeZ = Convert.ToInt32(Console.ReadLine());

int[,,] ArrayTriple = new int[SizeX, SizeY, SizeZ];

FillArrayRandomNumbers(ArrayTriple);
PrintArray(ArrayTriple);

void FillArrayRandomNumbers(int[,,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(2))
            {
                int element = new Random().Next(10, 100);
                if (FindElement(array, element)) continue;
                array[i, j, k] = element;
                k++;
            }
        }
    }
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();            
        }
    }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Эту задачу честно стырил из интернета. Сорри.

int size = 4;
int[,] Array = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Array.GetLength(0) * Array.GetLength(1))
{
    Array[i, j] = temp;
    temp++;
        if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
        {
            j++;
        }
        else 
        {
            if (i < j && i + j >= Array.GetLength(0) - 1)
            {
                i++;
            }
            else
            {
                if (i >= j && i + j > Array.GetLength(1) - 1)
                {
                    j--;
                }
                else
                {
                    i--;  
                }
            }
        }
}

WriteArray(Array);

void WriteArray(int[,] Arr)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] / 10 <= 0)
            {
                Console.Write($" {Array[i, j]} ");
            }
            else 
            {
                Console.Write($"{Array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}