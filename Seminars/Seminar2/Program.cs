void PrintDigit()
{
int x = new Random().Next(10,100);
Console.WriteLine($"Случайное число сгенерировалось {x}");
int x1 = x/10;
int x2 = x%10;
if (x1>x2) Console.WriteLine(x1);
else Console.WriteLine(x2);
}
PrintDigit();