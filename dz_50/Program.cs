/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

void FillArray (int [,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i,j] = new Random().Next(-10,11);
        }
    }
} 

void PrintArray (int [,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
} 

string Number (int N, int [,] myArray)
{
    string net = $"Числа {N} нет в массиве";
    string yes = $"Число {N} есть массиве";
    for (int k = 0; k < myArray.GetLength(0); k++)
    {
        for (int p = 0; p < myArray.GetLength(1); p++)
        {
            if (myArray[k,p] == N)
            return yes;
        }
    }
    return net;
}

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] myArray = new int [m,n];
FillArray(myArray);
PrintArray(myArray);
Console.Write("Введите элемент в массиве N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number(N,myArray));
