// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine ("Напишите начальное число A");
Console.Write ("A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Напишите конечное число B");
Console.Write ("B = ");
int B = Convert.ToInt32(Console.ReadLine());

int PowerRec(int A, int B)
{
    if (B==0) return 1;
    return A * PowerRec(A,B-1);
}
Console.WriteLine("A ^ B = " + PowerRec(A,B));