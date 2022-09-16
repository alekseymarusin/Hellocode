//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да


int[]array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (i!=array.Length-1) Console.Write($"{array[i]}, ");
    else Console.WriteLine($"{array[i]}");
}

int x = Convert.ToInt32(Console.ReadLine());
bool find = false;
foreach (var item in array)
{
    if (x == item)
    {
        find = true;
        break;
    }
}

if (find) Console.WriteLine("Да");
else Console.WriteLine ("Нет");
