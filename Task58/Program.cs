//Задайте две матрицы. Напишите программу,        (ak + bm) (al + bn)
//которая будет находить произведение двух матриц.(ck + dm) (cl + dn)

int size = 3;
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] matrixResult = new int[size, size];
FillArrayRandom(matrixA);
PrintArray(matrixA);
Console.WriteLine();
FillArrayRandom(matrixB);
PrintArray(matrixB);
Console.WriteLine();

for (int i = 0; i < size;i++)
{
    for (int j = 0; j < size;j++)
    {
        int res = 0;
        for (int k = 0; k < size; k++)
        {
            res += matrixA[i, k]*matrixB[k,j];
        }
        matrixResult[i,j] += res;
    }
}
Console.WriteLine("");
PrintArray(matrixResult);

void FillArrayRandom(int[,] mar)
{
    Random rand = new Random();
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            mar[i, j] = rand.Next(1, 5);
        }
    }  
} 

void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
           Console.Write(mat[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

