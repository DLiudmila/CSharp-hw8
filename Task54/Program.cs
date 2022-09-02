// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.



Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] marray = new int[m, n];
FillArrayRandom(marray);
Console.WriteLine("Исходный массив");
PrintArray(marray);
SortDescendingArray(marray);
Console.WriteLine("Результат");
PrintArray(marray);


void FillArrayRandom(int[,] mar)
{
    Random rand = new Random();
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            mar[i, j] = rand.Next(1, 10);
        }
    }  
} 

void PrintArray(int[,] mar)
{
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
           Console.Write(mar[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

void SortDescendingArray(int[,] mar)
{
  for (int i = 0; i < mar.GetLength(0); i++)
  {
    for (int j = 0; j < mar.GetLength(1); j++)
    {
      for (int k = 0; k < mar.GetLength(1) - 1; k++)
      {
        if (mar[i, k] < mar[i, k + 1])
        {
          int x = mar[i, k + 1];
          mar[i, k + 1] = mar[i, k];
          mar[i, k] = x;
        }
      }
    }
  }
}