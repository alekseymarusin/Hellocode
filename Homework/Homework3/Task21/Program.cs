// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

double Distance()
{
    Console.Write("Введите координату x1 ");
    double x1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Введите координату x2 ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y1 ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y2 ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z1 ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z2 ");
    double z2 = Convert.ToDouble(Console.ReadLine());
    double res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(z2-z1)+(z2-z1)*(z2-z1));

    return res;
}
try
{
    Console.WriteLine(Distance());
}
catch
{
    Console.WriteLine("Нужно было вводить только числа!");
}
