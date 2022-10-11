
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Количество строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество строк второй матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());


int[,] Matrix1()
{
    int[,] matrix1 = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (matrix1);
}

int[,] Matrix2()
{
    int[,] matrix2 = new int[c, d];
    for (int i = 0; i < c; i++)
    {
        for (int j = 0; j < d; j++)
        {
            matrix2[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (matrix2);
}

int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{  
    int[,] matrix3 = new int[a,d];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < d; j++)
        {
            matrix3[i, j] = matrix1[i,j]*matrix2[i,j] + matrix1[i+1,j]*matrix2[i,j+1];    
        }
    }
    Console.WriteLine();
    return(matrix3);
}

Matrix1();
Matrix2();

if(a == d) CompositionMatrix(Matrix1(),Matrix2());
else Console.WriteLine("Произведение этих двух матриц не существует!");