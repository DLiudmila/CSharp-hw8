//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] array = new int[2,2,2]{{{0,0}, {0,0}},{{0,0}, {0,0}}};
Fill3DArrayRandom(array);
Print3DArray(array);

void Fill3DArrayRandom(int[,,] mar)
{
    int x;
    Random rand = new Random();
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            for (int k = 0; k < mar.GetLength(2); k++)
            {
                x = rand.Next(10, 18);
                while(checkContains(mar, x))
                {
                    x = rand.Next(10, 18);
                }
                array[i,j,k] = x;
            }
        }
    }
}

bool checkContains(int[,,] mar, int val)
{
     for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            for (int k = 0; k < mar.GetLength(2); k++)
            {
                if (mar[i,j,k] == val)
                {
                   return true; 
                }
            }
        }        
    }
    return false;
}

void Print3DArray(int[,,] mar)
{
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            for (int k = 0; k < mar.GetLength(2); k++)
            {
                Console.Write(mar[i, j, k] + " (" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
}