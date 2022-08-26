

Console.WriteLine("Напишите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
x =  x/10;
x = x%10;
Console.WriteLine("Вторая цифра данного числа " + x);