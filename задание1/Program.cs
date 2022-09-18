// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = ReadInt ("Введите количество строк: ");
int columns = ReadInt ("Введите количество столбов: ");
int numbers = ReadInt ("Введите диапазон чисел: от 1 до ");

int[,] array = new int[rows, columns];
Console.WriteLine($"\nЗаданнй массив: ");
CreateArray2D(array);
PrintArray2D(array);

Console.WriteLine($"\nОтсортированный по убыванию массив: ");
OrderArray2D(array);
PrintArray2D(array);

void OrderArray2D(int[,] array)
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

void CreateArray2D(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(numbers);
    }
  }
}

void PrintArray2D(int[,] array)
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

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}