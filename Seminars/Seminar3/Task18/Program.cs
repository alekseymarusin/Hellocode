//Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y)

string NumQ()
    {
    Console.Write("Введите четверть ");
    int Q = Convert.ToInt32(Console.ReadLine());
    string res = "0";
    if (Q == 1) res = "x > 0 и y > 0";
    else if ( Q == 2 ) res = "x < 0 и y > 0";
    else if ( Q == 3 ) res = "x < 0 и y < 0";
    else if ( Q == 4 ) res = "x > 0 и y < 0"; 
    else res = "Quater nr must be within 1-4";
    return res;
    };
try
    {
    Console.WriteLine(NumQ());
    }
catch
    {
    Console.WriteLine("Надо было вводить числа от 1 до 4, и именно целые!");    
    }

