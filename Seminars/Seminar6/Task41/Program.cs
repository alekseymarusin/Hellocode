// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ConvertToBinary(int number)
{
    int result = 0;
    int order = 1;
    while (number > 0)
    {
        result += (number %2) * order;
        order *= 10;
        number /= 2;
    }
    return result;
}

void Task41()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{x} - {ConvertToBinary(x)}");
}

Task41();