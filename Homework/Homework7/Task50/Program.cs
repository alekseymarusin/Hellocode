// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
void Point(int[,] array)
{
    int c = array[a,b];
    if(a < m && b < n) Console.WriteLine(c);
    else Console.WriteLine("Такого элемента не существует!");
}
Point(mas);

