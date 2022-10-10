// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] NewMatrix()
{
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 10);
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
Console.WriteLine();
return (matrix);
}

int [] FrequencyDictionary(int[,] matrix)
{
int[] array = new int[10];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
array[matrix[i, j]] += 1;
}
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
Console.WriteLine($"Число {i} встречается {array[i]} раз");
}
}
Console.WriteLine();
}

PrintArray(FrequencyDictionary(NewMatrix()));
