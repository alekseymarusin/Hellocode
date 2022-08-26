Console.Write("Введите число a");
int a = Convert.ToInt32(Console.ReadLine ());
Console.Write("Введите число b");
int b = Convert.ToInt32(Console.ReadLine ());
Console.Write("Введите число c");
int c = Convert.ToInt32(Console.ReadLine ());
int max = a;

if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}

Console.Write(max);