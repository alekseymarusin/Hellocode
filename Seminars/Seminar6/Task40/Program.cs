// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

bool IsTrianglePossible(int a, int b, int c)
{
    return(a < b + c && b < a + c && c < a + b);
}

void Task40()
{
    Console.Write("Введите первую сторону треугольника: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{a}, {b}, {c} - треугольник ");
    if (!IsTrianglePossible(a,b,c))
    {
        Console.Write("не ");
    }
    Console.WriteLine("возможен.");
}

Task40();






