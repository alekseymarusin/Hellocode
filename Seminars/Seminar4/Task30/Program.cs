// Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный случайными целыми числами. 
// N - целое число и задается с клавиатуры.

Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[n];
for(int i = 0; i < n; i++)
{
numbers[i] = new Random().Next(1,100);
Console.Write($"{numbers[i]}, ");
}
