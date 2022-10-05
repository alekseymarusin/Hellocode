// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования. */

Console.WriteLine("Insert number");
int N = Convert.ToInt32(Console.ReadLine());

int []arr = new int[N];
arr[0] = 0;
arr[1] = 1;

for (int i = 2; i < N; i++)
{
arr[i] = arr[i-1] + arr[i-2];
}
Console.WriteLine(string.Join(",", arr));