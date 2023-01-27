/*Задача 50. Напишите программу, 
которая на вход принимает позиции 
элемента в двумерном массиве, и 
возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

Console.WriteLine("Введите номер позиции i и j элемента в массиве ");
int rowPos = Convert.ToInt32(Console.ReadLine());
int colPos = Convert.ToInt32(Console.ReadLine());          
if (rowPos < 0 || rowPos > dimensArray.GetLength(0) - 1 || colPos < 0 || colPos > dimensArray.GetLength(1) - 1) 
    { 
        Console.WriteLine("Такого числа нету в данном массиве."); 
    } 
else 
    { 
        Console.WriteLine($"На позиции ({rowPos},{colPos}) находится число: {dimensArray[rowPos, colPos]}"); 
    }
