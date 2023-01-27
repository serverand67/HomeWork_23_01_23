/*Задача 47. Задайте двумерный массив 
размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void SetAnArray( double[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            dimensArray[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            //new Random().Next(1,10);
        }
    }
}
void printDemArr(double[,] dimensArray)
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
double[,] dimensArray = new double [3,4];
printDemArr(dimensArray);
Console.WriteLine();
SetAnArray(dimensArray);
printDemArr(dimensArray);