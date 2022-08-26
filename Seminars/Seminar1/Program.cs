Console.Write("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine ());
if (x==0)
{
Console.WriteLine("Ноль и в Африке ноль");    
}
else    x=x*x;
Console.WriteLine("Квадрат этого числа будет"+x*x);