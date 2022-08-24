void PrintDigit()
{
Console.WriteLine("Введите первое число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int x2 = Convert.ToInt32(Console.ReadLine());
if (x1 > x2) 
{
   if (x1 % x2 == 0) 
   Console.WriteLine("Кратно");
   else
   Console.WriteLine("Некратно, остаток " + x1%x2);
}
else 
{
    if (x2 % x1 == 0)
    Console.WriteLine("Кратно");
    else 
    Console.WriteLine("Некратно, остаток " + x2%x1);
}
}
PrintDigit();