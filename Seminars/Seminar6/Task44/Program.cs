// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите количество чисел, необходимых для вывода: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0, b = 1, c = 0;

if (n == 0) Console.Write(a);
else if (n == 1) Console.Write(a + " " + b);
else
{
Console.Write(a + " " + b + " ");
for (int i = 2; i < n; i++)
{
c = a + b;
Console.Write(c + " ");
a = b;
b = c;
}
}
Console.WriteLine();

