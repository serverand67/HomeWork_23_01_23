/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void SetAnArray( int[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            dimensArray[i,j] = new Random().Next(1,10);;
        }
    }
}
void printDemArr(int[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            Console.Write($"{dimensArray[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] dimensArray = new int [3,4];
printDemArr(dimensArray);
Console.WriteLine();
SetAnArray(dimensArray);
printDemArr(dimensArray);
Console.WriteLine();

double numAverage = 0;
for (int j = 0; j < dimensArray.GetLength(1); j++)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        numAverage = numAverage + dimensArray[i, j];
    }
    double result = numAverage / dimensArray.GetLength(0);
    Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {result}");
    numAverage = 0;
}
