// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int rows =6,
cols = 5;
int [,] table = new int[rows,cols];
FillArray(table);
PrintArray(table);

int temp = 0;

for (int i = 0; i < cols; i++)
{
temp = table [0,i];
table [0,i] = table [rows-1,i];
table [rows-1,i] = temp;
}

Console.WriteLine();

PrintArray(table);
