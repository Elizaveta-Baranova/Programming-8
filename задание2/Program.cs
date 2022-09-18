// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = ReadInt ("Введите количество строк: ");
int columns = ReadInt ("Введите количество столбов: ");
if (rows != columns)
{
    Console.WriteLine("Вы ввели не равное количество строк и столбцов, поэтому массив не может быть прямоугольным!");
    return;
}
int numbers = ReadInt ("Введите диапазон чисел: от 1 до ");

int[,] array = new int[rows, columns];
Console.WriteLine($"\nЗаданнй массив: ");
CreateArray2D(array);
PrintArray2D(array);

int minSum = 0;
int sum = SumLine (array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumLine (array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой элементов ({sum}) ");


int SumLine (int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
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