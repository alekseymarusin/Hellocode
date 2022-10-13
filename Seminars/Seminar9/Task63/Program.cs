// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string SequenceRec(int N)
{
    if (N==0) return "";
    return SequenceRec(N-1) + " " + Convert.ToString(N);
}
try
{
    Console.WriteLine("Введите натуральное число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SequenceRec(n));

}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}
