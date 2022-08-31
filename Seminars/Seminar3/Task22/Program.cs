//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void TableOfCubesN()
{
    Console.Write("Введите чиcло ");
    int N = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < (N+1); i++)
    {
        Console.Write($"{i * i * i}, ");
    }
}
try
{
    TableOfCubesN();
}
catch
{
    Console.WriteLine("Надо было вводить целые числа");
}