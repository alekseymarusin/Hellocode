//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen()
{
    Console.WriteLine("Введите число А, которое будут возводить в степень В");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число В");
    int B = Convert.ToInt32(Console.ReadLine());
    int result = A;
    if (B > 0)
    {
        for(int i = 1; i < B; i++)
        {
            result = result * A;
        }
    }
    else 
        Console.WriteLine("Число B должно быть натуральным, т.е. 1 или больше");
    return result;
}
try
{
    Console.WriteLine(Stepen());
}
catch
{
    Console.WriteLine("Нужно было вводить числа!");
}