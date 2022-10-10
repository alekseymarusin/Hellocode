// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void FillArray(int[,] table)
{
Random random = new Random();
for (int i = 0; i < table.GetLength(0); i++)
{
for (int j = 0; j < table.GetLength(1); j++)
{
table[i, j] = random.Next(10);
}
}
}

void PrintArray(int[,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
for (int j = 0; j < table.GetLength(1); j++)
{
Console.Write(table[i, j] + "\t");
}
Console.WriteLine();
}
}

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols = Convert.ToInt32 (Console.ReadLine());
int [,] table = new int[rows,cols];

FillArray(table);
PrintArray(table);

if (rows != cols) Console.WriteLine("Так не получится");
else
{
int temp = 0;
for (int i = 0; i < rows; i++)
for (int j = i; j < cols; j++)
{
temp = table [i,j];
table [i,j] = table [j,i];
table [j,i] = temp;
}
Console.WriteLine();
PrintArray(table);
}