// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine ("Напишите число N");
Console.WriteLine ("N= ");
int N = Convert.ToInt32(Console.ReadLine());

int SumRec(int N)
{
    if (N==0) return 0;
    return N%10 + SumRec(N / 10);
}
Console.WriteLine(SumRec(N));