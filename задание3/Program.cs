// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = ReadInt ("Введите количество строк: ");
int columns = ReadInt ("Введите количество столбов: ");
int numbers = ReadInt ("Введите диапазон чисел: от 1 до ");

int[,] firstMatrix = new int[rows, columns];
Console.WriteLine($"\nПервая матрица: ");
CreateArray2D(firstMatrix);
PrintArray2D(firstMatrix);

int[,] secomdMatrix = new int[rows, columns];
Console.WriteLine($"\nВторая матрица: ");
CreateArray2D(secomdMatrix);
PrintArray2D(secomdMatrix);

int[,] resultMatrix = new int[rows, columns];
ProductMatrix(firstMatrix, secomdMatrix, resultMatrix);
Console.WriteLine($"\nРезультирующая матрица:");
PrintArray2D(resultMatrix);

void ProductMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secomdMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
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