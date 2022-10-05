// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

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

    if (IsTrianglePossible == true)
    {
        Console.WriteLine("Периметр равен " + (a + b + c));
        Console.WriteLine("Площадь равна " + )
    }
}

Task40();