// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber()
{
Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 99) Console.WriteLine("Третьей цифры нет");
else 
    {
        while (x > 999) 
        {
            x = x/10;
        }
    Console.WriteLine("Третья цифра этого числа " + x%10);
    }
}
ThirdNumber();
