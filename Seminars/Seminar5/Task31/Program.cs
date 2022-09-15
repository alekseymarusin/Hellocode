// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


int[]array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (i!=array.Length-1) Console.Write($"{array[i]}, ");
    else Console.WriteLine($"{array[i]}");
}

int sum_p = 0;
int sum_n = 0;

string s = "";

foreach(int item in array)
{
    if (item > 0) 
        {
        sum_p += item;
        s+=$"{item}+";
        }
    else sum_n += item;
}

Console.WriteLine($"Сумма положительных чисел {s} равна {sum_p}");
Console.WriteLine($"Сумма отрицательных чисел равна {sum_n}");
