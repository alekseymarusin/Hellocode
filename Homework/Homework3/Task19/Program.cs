// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom()
{
    Console.Write("Введите пятизначное число ");
    int x = Convert.ToInt32(Console.ReadLine());
    if ((x < 99999) && (x > 10000))
        {
        int x1 = x / 10000;
        int x2 = (x / 1000) % 10; 
        int x4 = (x / 10) % 10;
        int x5 = x % 10;
        if ((x1 == x5) && (x2 == x4))
            Console.WriteLine("Это число является палиндромом");
        else
            Console.WriteLine("Это число не является палиндромом");
        }
    else
        Console.WriteLine("Нужно ввести именно пятизначное число!");
}
try
{
    Palindrom();
}
catch
{
    Console.WriteLine("Нужно было вводить пятизначное число!");
}