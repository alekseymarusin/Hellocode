int Stepen()
{
    Console.WriteLine("Введите число А, которое будут возводить в степень В");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число В");
    int B = Convert.ToInt32(Console.ReadLine());
    if (B > 0)
    {
        for (int i = 0; i < B; i++);
        {
            A = A*A;
        }
    }
    else 
        Console.WriteLine("Число B должно быть натуральным, т.е. 1 или больше");
    return A;
}
try
{
    Console.WriteLine(Stepen());
}
catch
{
    Console.WriteLine("Нужно было вводить числа!");
}