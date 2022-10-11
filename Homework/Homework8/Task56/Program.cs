// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] NewMatrix()
{
    int[,] matrix = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (matrix);
}

void MinimalSummaString (int[,] matrix)
{
    int summa;
    int minimalSumma = 0;
    int iMin = 0;
    for (int i = 0; i < m; i++)
    {
        summa = 0;
        for (int j = 0; j < m; j++)
        {
            summa += matrix[i,j];
        }
        if (i == 0) minimalSumma = summa;
        else if (summa < minimalSumma) minimalSumma = summa;
        iMin = i;
    }
    Console.WriteLine("Номер строки с минимальной суммой: " + iMin);
}

MinimalSummaString(NewMatrix());