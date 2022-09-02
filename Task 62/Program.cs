//Напишите программу, которая заполнит спирально массив 4 на 4.

int size = 9;
int[,] array = new int[size,size];

int xStart = 0; 
int yStart = 0;
int xStop = array.GetLength(0);
int yStop = array.GetLength(1);
int startValue = 10;
while (xStart <= xStop && yStart <= yStop)
{
    for (int i = xStart; i < xStop; i++)
    {
        array[yStart, i] = startValue;
        startValue++;
    }  
    yStart++;
    for (int j = yStart; j < yStop; j++)
    {
        array[j, xStop-1] = startValue;
        startValue++;
    }
    xStop--;
    for (int k = xStop-1; k >= xStart; k--) 
    {
        array[yStop-1, k] = startValue;
        startValue++;
    }
    yStop--;
    for (int l = yStop-1; l >= yStart ; l--)
    {
        array[l, xStart] = startValue;
        startValue++;
    }    
    xStart++;
}

PrintArray(array);



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