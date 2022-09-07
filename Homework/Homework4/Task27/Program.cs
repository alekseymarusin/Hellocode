//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите любое число ");
int x = Convert.ToInt32(Console.ReadLine());
int Summa(int x)
{    
    int count = Convert.ToString(x).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = x - x % 10;
        result = result + (x - advance);
        x = x / 10;
    }
   return result;
}
try
{
    Console.WriteLine("Сумма цифр этого числа " + Summa(x));
}
catch
{
    Console.WriteLine("Нужно было вводить числа!");
}
