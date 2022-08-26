try
    {
    Console.Write("Введите четверть ");
    int Q = Convert.ToInt32(Console.ReadLine());
    if (Q == 1) Console.WriteLine("x > 0 и y > 0");
    else if ( Q == 2 ) Console.WriteLine("x < 0 и y > 0");
    else if ( Q == 3 ) Console.WriteLine("x < 0 и y < 0");
    else if ( Q == 4 ) Console.WriteLine("x > 0 и y < 0"); 
    else Console.WriteLine("Область должна быть от 1 до 4");
    }
Console.WriteLine(" ");

catch
{
    Console.WriteLine("Надо было вводить числа от 1 до 4, и именно целые!");    
}

