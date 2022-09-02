// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] marray = new int[m, n];
FillArrayRandom(marray);
Console.WriteLine("Исходный массив");
PrintArray(marray);

int minSum = int.MaxValue;
int minIndex = -1;

for (int i = 0; i < marray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < marray.GetLength(1); j++)
    {
        sum += marray[i,j];
    }
    // Console.WriteLine("сумма элементов в строке № " + i + " равна " + sum);
    if (sum < minSum)
    {
        minSum = sum;
        minIndex = i;
    }
}
Console.WriteLine("Наименьшая сумма элементов в строке с индексом № " + minIndex);



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

