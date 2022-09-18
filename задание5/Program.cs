// Напишите программу, которая заполнит спирально массив 4 на 4.

int rows = 4;
int columns = rows;

int[,] spiral = new int[rows, columns];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiral.GetLength(0) * spiral.GetLength(1))
{
spiral[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiral.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiral.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiral.GetLength(1) - 1)
    j--;
  else
    i--;
} 

Console.WriteLine($"\nСпиральная матрица: ");
PrintArray2D(spiral);

void PrintArray2D(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < 10)
        {
            Console.Write ("0");
        }
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}