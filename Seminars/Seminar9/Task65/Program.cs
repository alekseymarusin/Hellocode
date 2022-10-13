// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string SequenceSegmentRec(int M, int N)
{
    if (N== M - 1) return "";
    return SequenceSegmentRec(M, N-1) + " " + Convert.ToString(N);
}
try
{
    Console.WriteLine("Введите натуральные числа");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SequenceSegmentRec(m, n));
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}