Console.Write("Введите четверть ");
int Q = int.Parse(Console.ReadLine());
if (Q == 1) Console.WriteLine("x > 0 и y > 0");
else if ( Q == 2 ) Console.WriteLine("x < 0 и y > 0");
else if ( Q == 3 ) Console.WriteLine("x < 0 и y < 0");
else if ( Q == 4 ) Console.WriteLine("x > 0 и y < 0"); 
else Console.WriteLine("Область должна быть от 1 до 4");

try

catch
{
Console.WriteLine("Надо было вводить числа от 1 до 4, и именно целые!");    
}

