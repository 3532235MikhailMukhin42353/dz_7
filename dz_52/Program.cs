/*Задача 52. Задайте двумерный массив из целых чисел. Найдите ср ар-кое элементов в каждом столбце.*/

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[m, n];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
Sum(myArray);

void FillArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] myArray)

{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Sum(int[,] myArray)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            result = result + myArray[i, j];
        }
        result = result / m;
        Console.Write(result + "\t");
    }
}